using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kasir_pedagang_kaki_lima
{
    public partial class Formmaster : Form
    {
        public MySqlCommand cmd;
        public string idden;
        public Formmaster()
        {
            InitializeComponent();
        }

        void Tampil()
        {
            try
            {
                //MessageBox.Show("Ini Muncul Saat FOrm dipanggil");

                Koneksi.conn.Open(); //ini membuka koneksi database

                //ini digunakan untuk mengambil data di tabel siswa
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi.conn);
                //membuat objek Dasa Set Baru
                DataSet ds = new DataSet();
                //ini digunakan untuk mengisi dataset dari Data Adapter
                adapter.Fill(ds);

                //Mengisi DataGrid Siswa dengan DataSet
                dgudentitas.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog(this);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahkategori f2 = new tambahkategori();
            f2.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tambahpelanggan f2 = new tambahpelanggan();
            this.Hide();
            f2.ShowDialog();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahbarangcs tambahbarangcs = new tambahbarangcs();
            tambahbarangcs.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menumaster menumaster = new Menumaster();
            menumaster.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblidentitas` SET `namatoko` = '"+namatoko.Text+"', `alamatoko` = '"+alamatoko.Text+"', `notlpn` = '"+telepon.Text+"', `captionpertama` = '"+pertama.Text+"', `captionkedua` = '"+kedua.Text+"', `captionketiga` = '"+ketiga+"' WHERE `tblidentitas`.`id_identitas` = '"+ idden +"';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();

                Tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //crud tambh
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`id_identitas`, `namatoko`, `alamatoko`, `notlpn`, `captionpertama`, `captionkedua`, `captionketiga`) VALUES (NULL, '" + namatoko.Text + "', '" + alamatoko.Text + "', '" + telepon.Text + "', '" + pertama.Text + "', '" + kedua.Text + "', '" + ketiga.Text + "');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Siswa");
                Koneksi.conn.Close();

                Tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //crud hps
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM `tblidentitas` WHERE `tblidentitas`.`id_identitas` = '"+idden+"'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus Data Siswa");
                Koneksi.conn.Close();

                Tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Hapus Data Gagal");
            }
        }

        private void dgudentitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int baris = dgudentitas.CurrentCell.RowIndex;
                idden = dgudentitas.Rows[baris].Cells[0].Value.ToString();
                namatoko.Text = dgudentitas.Rows[baris].Cells[1].Value.ToString();
                alamatoko.Text = dgudentitas.Rows[baris].Cells[2].Value.ToString();
                telepon.Text = dgudentitas.Rows[baris].Cells[3].Value.ToString();
                pertama.Text = dgudentitas.Rows[baris].Cells[4].Value.ToString();
                kedua.Text = dgudentitas.Rows[baris].Cells[5].Value.ToString();
               ketiga.Text = dgudentitas.Rows[baris].Cells[6].Value.ToString();
    
            }

        private void Formmaster_Load(object sender, EventArgs e)
        {
            Tampil();
           
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblidentitas` SET `namatoko` = '" + namatoko.Text + "', `alamatoko` = '" + alamatoko.Text + "', `notlpn` = '" + telepon.Text + "', `captionpertama` = '" + pertama.Text + "', `captionkedua` = '" + kedua.Text + "', `captionketiga` = '" + ketiga + "' WHERE `tblidentitas`.`id_identitas` = '" + idden + "';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("hai man");
                Koneksi.conn.Close();

                Tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal kapok");
            }
            
        }

        private void btcancel_Click(object sender, EventArgs e)
        {

        }
    }
    }

