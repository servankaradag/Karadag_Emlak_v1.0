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
    public partial class Secim2_Isyeri_Kiralik : Form
    {
        public Secim2_Isyeri_Kiralik()
        {
            InitializeComponent();
        }

        private void btnTumunuTemizle_Click(object sender, EventArgs e)
        {
            txtFiyat.Text = "";
            txtMetrekare.Text = "";
            txtAdres.Text = "";
            txtAdres.Text = "";
            txtAciklama.Text = "";
        }
    }
}
