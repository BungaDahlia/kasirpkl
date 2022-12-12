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

namespace kasir_pedagang_kaki_lima
{
    public partial class DaftarHutang : Form
    {
        public DaftarHutang()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaksipenjualan tp = new transaksipenjualan();
            tp.ShowDialog();
            
        
    }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menutransaksi menutransaksi = new Menutransaksi();
            menutransaksi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
