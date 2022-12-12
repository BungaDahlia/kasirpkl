using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_pedagang_kaki_lima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Crud dahlia = new Crud();
            //crud.tampil("SELECT * FROM 'Spots'", "tampil", Luna);
            //crud.tampil("SELECT * FROM 'User'", "combo", Luna, Ibra, "id_user", "name");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menumaster menumaster = new Menumaster();
            menumaster.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menutransaksi menutransaksi
                = new Menutransaksi();
            menutransaksi.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try

            {

                Koneksi.conn.Open();

                MessageBox.Show("Koneksi Database Berhasil");
            }
            catch (Exception)

            {

                MessageBox.Show("Koneksi Gagal");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
