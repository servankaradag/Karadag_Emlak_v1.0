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
    public partial class Secim3_Arsa : Form
    {
        Hakkinda frm1 = new Hakkinda();
        public Secim3_Arsa()
        {
            InitializeComponent();
        }

        private void msSatilik_Click(object sender, EventArgs e)
        {
            Secim3_Arsa_Satilik frm1 = new Secim3_Arsa_Satilik();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void msHakkinda_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

        private void Secim3_Arsa_Load(object sender, EventArgs e)
        {

        }

        private void msEmlakSahip_Click(object sender, EventArgs e)
        {
            Secim3_Arsa_Arama frm2 = new Secim3_Arsa_Arama();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void msKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msAnaMenü_Click(object sender, EventArgs e)
        {
        }
    }
}
