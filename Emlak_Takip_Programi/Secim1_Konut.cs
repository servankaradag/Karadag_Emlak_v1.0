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
    public partial class Secim1_Konut : Form
    {
        Hakkinda frm1 = new Hakkinda();
        Secim1_Konut_Arama frm2 = new Secim1_Konut_Arama();
        public Secim1_Konut()
        {
            InitializeComponent();
        }

        private void msSatilik_Click(object sender, EventArgs e)
        {
            Secim1_Konut_Satilik frm1 = new Secim1_Konut_Satilik();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void msKiralik_Click(object sender, EventArgs e)
        {
            Secim1_Konut_Kiralik frm2 = new Secim1_Konut_Kiralik();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void Secim1_Konut_Load(object sender, EventArgs e)
        {

        }

        private void msHakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda frm4 = new Hakkinda();
            frm4.MdiParent = this;
            frm4.Show();
            
        }

        private void msEmlakSahip_Click(object sender, EventArgs e)
        {
            Secim1_Konut_Arama frm3 = new Secim1_Konut_Arama();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void msKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msAnaMenu_Click(object sender, EventArgs e)
        {
            
        }


    }
}
