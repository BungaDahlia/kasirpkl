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
    public partial class Menutransaksi : Form
    {
        public Menutransaksi()
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
            transaksipenjualan transaksipenjualan 
                = new transaksipenjualan();
            transaksipenjualan.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarHutang daftarHutang = new DaftarHutang();
            daftarHutang.ShowDialog(); 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Return @return = new Return();
            @return.ShowDialog();
        }
    }
}
