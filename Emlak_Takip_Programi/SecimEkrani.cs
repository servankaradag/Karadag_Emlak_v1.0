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
    public partial class SecimEkrani : Form
    {
        Secim1_Konut frm1 = new Secim1_Konut();
        Secim2_Isyeri frm2 = new Secim2_Isyeri();
        Secim3_Arsa frm3 = new Secim3_Arsa();
        public SecimEkrani()
        {
            InitializeComponent();
        }

        private void SecimEkrani_Load(object sender, EventArgs e)
        {
            pcIkon.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void btnKonut_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }

        private void btnİsyeri_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void btnArsa_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Close();
        }
    }
}
