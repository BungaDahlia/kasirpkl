using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kasir_pedagang_kaki_lima
{
    
        public partial class tambahpelanggan : Form
        {
        public MySqlCommand cmd;
        public string idpelanggan;


        Koneksi koneksi = new Koneksi();

            public void Tampil()
            {
                //Query Database
               //DataTable1.DataSource = koneksi.ShowData("SELECT * FROM `tblpelanggan");
            }
            public tambahpelanggan()
            {
                InitializeComponent();
            }
         void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi.conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgpelanggan.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label3_Click(object sender, EventArgs e)
            {

            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {

            }

            private void button19_Click(object sender, EventArgs e)
            {
                this.Hide();
                tambahbarangcs tambahbarangcs = new tambahbarangcs();
                tambahbarangcs.ShowDialog();


            }

            private void button18_Click(object sender, EventArgs e)
            {
                this.Hide();
                tambahkategori tambahkategori = new tambahkategori();
                tambahkategori.ShowDialog();

            }

            private void button17_Click(object sender, EventArgs e)
            {
                this.Hide();
                Formmaster formmaster = new Formmaster();
                formmaster.ShowDialog();

            }

            private void button14_Click(object sender, EventArgs e)
            {
                this.Hide();
                Menumaster menumaster = new Menumaster();
                menumaster.ShowDialog();
            }

            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
 
            }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tambahpelanggan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //crud tambh
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblpelanggan` (`id_pelanggan`, `pelanggan`, `alamat`, `notlpn`) VALUES ('1', '"+textBox3.Text+"', '"+textBox2.Text+"', '"+textBox1.Text+"');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Siswa");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }
        }

        private void dgpelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgpelanggan.CurrentCell.RowIndex;
            idpelanggan = dgpelanggan.Rows[baris].Cells[0].Value.ToString();
            textBox3.Text = dgpelanggan.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = dgpelanggan.Rows[baris].Cells[2].Value.ToString();
            textBox1.Text = dgpelanggan.Rows[baris].Cells[3].Value.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblpelanggan` SET `id_pelanggan` = '3', `pelanggan` = '" + textBox3.Text + "'  , `alamat` = '" + textBox2.Text + "', `notlpn` = '" + textBox1.Text + "' WHERE `tblpelanggan`.`id_pelanggan` = '" + idpelanggan + "';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Update");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblpelanggan` SET `id_pelanggan` = '12', `pelanggan` = '"+textBox3.Text+"', `alamat` = '"+textBox2.Text+"', `notlpn` = '"+textBox1.Text+"' WHERE `tblpelanggan`.`id_pelanggan` = '"+idpelanggan+"';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //crud hps
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM `tblpelanggan` WHERE `tblpelanggan`.`id_pelanggan` = '" + idpelanggan + "' "; ", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus Data Siswa");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Hapus Data Gagal");
            }
        }
    }
    }

    private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
    


