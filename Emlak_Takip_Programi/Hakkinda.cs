﻿using System;
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
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void lnkIletisim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.servankaradag.xyz");
        }

        private void Hakkinda_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }
    }
}