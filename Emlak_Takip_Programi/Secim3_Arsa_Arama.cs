using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Emlak_Takip_Programi
{
    public partial class Secim3_Arsa_Arama : Form
    {
        public Secim3_Arsa_Arama()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamReader sr;
        string satir;

        private void Secim3_Arsa_Arama_Load(object sender, EventArgs e)
        {
            dgKayitlar.ColumnCount = 6;
            dgKayitlar.Columns[0].Name = "İlan Kodu";
            dgKayitlar.Columns[1].Name = "Ad";
            dgKayitlar.Columns[2].Name = "Soyad";
            dgKayitlar.Columns[3].Name = "Şehir";
            dgKayitlar.Columns[4].Name = "Telefon No";
            dgKayitlar.Columns[5].Name = "Amacı";

        }

        private void btnKayitGoruntule_Click(object sender, EventArgs e)
        {
            int i = dgKayitlar.Rows.Add();

            i = 0;

            dgKayitlar.Rows[i].Cells[0].Value = 1;
            dgKayitlar.Rows[i].Cells[1].Value = "Servan";
            dgKayitlar.Rows[i].Cells[2].Value = "KARADAĞ";
            dgKayitlar.Rows[i].Cells[3].Value = "Antalya";
            dgKayitlar.Rows[i].Cells[4].Value = "0538 729 1863";
            dgKayitlar.Rows[i].Cells[5].Value = "Satılık";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int i = dgKayitlar.Rows.Add();
            i = 0;

            dgKayitlar.Rows[i].Cells[0].Value = txtIlanKodu.Text;
            dgKayitlar.Rows[i].Cells[1].Value = txtAd.Text;
            dgKayitlar.Rows[i].Cells[2].Value = txtSoyad.Text;
            dgKayitlar.Rows[i].Cells[3].Value = cbSehir.Text;
            dgKayitlar.Rows[i].Cells[4].Value = txtTelefon.Text;
            dgKayitlar.Rows[i].Cells[5].Value = cbAmac.Text;
        }

        private void btnDosyac_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Dosyalar |*.csv";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs, Encoding.GetEncoding(1254));

            int s = 1;
            while ((satir = sr.ReadLine()) != null)
            {

                string[] parcala = satir.Split(';');

                dgKayitlar.Rows.Add(s, parcala[0], parcala[1], parcala[2], parcala[3]);
                s++;
            }
            sr.Close();
            fs.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }
