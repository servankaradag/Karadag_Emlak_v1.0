using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Takip_Programi
{
    public partial class Secim1_Konut_Satilik : Form
    {
        public Secim1_Konut_Satilik()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTumunuTemizle_Click(object sender, EventArgs e)
        {
            txtFiyat.Text = "";
            txtMetrekare.Text = "";
            txtEklenmeTarihi.Text = "";
            txtAdres.Text = "";
            txtAciklama.Text = "";
            txtAidatTutari.Text = "";
        }
    }
}
