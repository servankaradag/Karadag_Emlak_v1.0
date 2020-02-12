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
    public partial class Giris : Form
    {
        SecimEkrani frm = new SecimEkrani();
        Sifremi_Unuttum frm2 = new Sifremi_Unuttum();
        private int zaman;
        public Giris()
        {
            InitializeComponent();
        }
        Point nokta = new Point();
        int x, y;
        private void Giris_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            zaman = 120;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            lbSayi.Text = zaman.ToString();
            if (zaman == 0)
                Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sifre;
            sifre = txtGiris.Text;
            if (sifre == "123")
                frm.Show();
            else
                MessageBox.Show("Hatalı Giriş Yaptınız", "Hata");
            this.Hide();
            return;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbSaat.Text = dt.ToLongTimeString();
            lbTarih.Text = dt.ToLongDateString();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            prgGiris.Style = ProgressBarStyle.Marquee;
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                nokta = Control.MousePosition;
                nokta.X = nokta.X - x;
                nokta.Y = nokta.Y - y;
                this.Location = nokta;
            }
        }

        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X;
            y = Control.MousePosition.Y;
        }

        private void lnkSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm2.Show();
        }
    }
}
