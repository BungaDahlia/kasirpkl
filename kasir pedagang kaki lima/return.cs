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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
             

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DaftarHutang daftarHutang = new DaftarHutang();
            daftarHutang.ShowDialog();
            this.Hide();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            transaksipenjualan tp= new transaksipenjualan();
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
