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
    public partial class Menumaster : Form
    {
        public Menumaster()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmaster formmaster = new Formmaster();
            formmaster.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahkategori tambahkategori = new tambahkategori();
            tambahkategori.ShowDialog();
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
            tambahpelanggan tambahpelanggan = new tambahpelanggan();
            tambahpelanggan.ShowDialog();
        }

        private void Menumaster_Load(object sender, EventArgs e)
        {

        }
    }
}
