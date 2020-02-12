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
    public partial class Secim2_Isyeri : Form
    {
        Hakkinda frm1 = new Hakkinda();
        public Secim2_Isyeri()
        {
            InitializeComponent();
        }

        private void msSatilik_Click(object sender, EventArgs e)
        {
            Secim2_Isyeri_Satilik frm1 = new Secim2_Isyeri_Satilik();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void msKiralik_Click(object sender, EventArgs e)
        {
            Secim2_Isyeri_Kiralik frm2 = new Secim2_Isyeri_Kiralik();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void Secim2_Isyeri_Load(object sender, EventArgs e)
        {

        }

        private void msHakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda frm3 = new Hakkinda();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void msEmlakSahip_Click(object sender, EventArgs e)
        {
            Secim2_Isyeri_Arama frm4 = new Secim2_Isyeri_Arama();
            frm4.MdiParent = this;
            frm4.Show();
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