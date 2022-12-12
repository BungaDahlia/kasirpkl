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
    public partial class transaksipenjualan : Form
    {
        public transaksipenjualan()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return ret = new Return();
            ret.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarHutang daftarHutang = new DaftarHutang();
            daftarHutang.ShowDialog(); 
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void transaksipenjualan_Load(object sender, EventArgs e)
        {
          
        }
    }
}

  

      