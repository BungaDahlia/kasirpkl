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
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kasir_pedagang_kaki_lima
{
    public partial class tambahbarangcs : Form
    {
        MySqlCommand cmd;
        public string idbarang;
        public tambahbarangcs()
        {
            InitializeComponent();
        }

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `tblbarang`", Koneksi.conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgbarang.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {


        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmaster formmaster = new Formmaster();
            formmaster.ShowDialog();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahpelanggan tambahpelanggan = new tambahpelanggan();
            tambahpelanggan.ShowDialog();

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            tambahkategori tambahkategori = new tambahkategori();
            tambahkategori.ShowDialog();
        }

        private void tambahbarangcs_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {

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
                cmd = new MySqlCommand("INSERT INTO `tblbarang` (`id_barang`, `id_kategori`, `hargabeli`, `hargajual`, `barang`, `stok`, `ketbarang`) VALUES (NULL, '', '" + beli.Text + "', '" + katgori.Text + "', '" + barang.Text + "', '" + jual.Text + "', '" + dgbarang.Text + "');", Koneksi.conn);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //crud edit
                Koneksi.conn.Open();
                cmd = new MySqlCommand("'UPDATE `tblbarang` SET `hargabeli` = '" + beli.Text + "', `hargajual` = '" + jual.Text + "', `barang` = '" + barang.Text + "', `stok` = '" + stok.Text + "', `ketbarang` = '" + kulakan.Text + "' WHERE `tblbarang`.`id_barang` = '" + idbarang + "';", Koneksi.conn);
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
                cmd = new MySqlCommand("DELETE FROM `tblbarang` WHERE `tblbarang`.`id_barang` = '"+idbarang+"'", Koneksi.conn);
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
                cmd = new MySqlCommand("UPDATE `tblbarang` SET `id_kategori` = '5', `hargabeli` = '"+beli.Text+"', `hargajual` = '"+jual.Text+"', `barang` = '"+barang.Text+"', `stok` = '"+stok.Text+"', `ketbarang` = '"+kulakan+"' WHERE `tblbarang`.`id_barang` = '"+idbarang+"';", Koneksi.conn);
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

        private void dgbarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampil();
        }

        private void dgbarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgbarang.CurrentCell.RowIndex;
            idbarang = dgbarang.Rows[baris].Cells[0].Value.ToString();
            barang.Text = dgbarang.Rows[baris].Cells[1].Value.ToString();
            beli.Text = dgbarang.Rows[baris].Cells[2].Value.ToString();
            katgori.Text = dgbarang.Rows[baris].Cells[3].Value.ToString(); 
            jual.Text = dgbarang.Rows[baris].Cells[4].Value.ToString();
            stok.Text = dgbarang.Rows[baris].Cells[5].Value.ToString();
            kulakan.Text = dgbarang.Rows[baris].Cells[6].Value.ToString();    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


