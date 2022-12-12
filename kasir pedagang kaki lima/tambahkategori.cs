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
    public partial class tambahkategori : Form
    {
        MySqlCommand cmd;
        public string idkategori;
        public tambahkategori()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter da=new MySqlDataAdapter("SELECT * FROM `tblkategori`", Koneksi.conn); 
            DataSet ds=new DataSet();
            da.Fill(ds);
            gkategori.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
          
      }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmaster formmaster = new Formmaster();
            formmaster.ShowDialog();   
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahbarangcs tambahbarangcs = new tambahbarangcs();
            tambahbarangcs.ShowDialog();
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahpelanggan tambahpelanggan  = new tambahpelanggan();
            tambahpelanggan.ShowDialog();
            
        }

        private void tambahkategori_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menumaster menumaster = new Menumaster();
            menumaster.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //crud tambh
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblkategori` (`id_kategori`, `kategori`) VALUES ('"+idkategori+"', '"+textBox3.Text+"');", Koneksi.conn);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gkategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = gkategori.CurrentCell.RowIndex;
            idkategori = gkategori.Rows[baris].Cells[0].Value.ToString();
            textBox3.Text = gkategori.Rows[baris].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblkategori` SET `id_kategori` = NULL, `kategori` = '"+textBox3+"' WHERE `tblkategori`.`id_kategori` = '"+idkategori+"';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //crud hps
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM `tblkategori` WHERE `tblkategori`.`id_kategori` = '"+idkategori+"'", Koneksi.conn);
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblkategori` SET `kategori` = '"+textBox3.Text+"' WHERE `tblkategori`.`id_kategori` = '"+idkategori+"';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("hai man");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal kapok");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
