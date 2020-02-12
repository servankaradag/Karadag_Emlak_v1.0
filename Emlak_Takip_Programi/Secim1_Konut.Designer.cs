namespace Emlak_Takip_Programi
{
    partial class Secim1_Konut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secim1_Konut));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msEmlakSahip = new System.Windows.Forms.ToolStripMenuItem();
            this.msSatilik = new System.Windows.Forms.ToolStripMenuItem();
            this.msKiralik = new System.Windows.Forms.ToolStripMenuItem();
            this.msHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.msKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEmlakSahip,
            this.msSatilik,
            this.msKiralik,
            this.msHakkinda,
            this.msKapat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msEmlakSahip
            // 
            this.msEmlakSahip.Name = "msEmlakSahip";
            this.msEmlakSahip.Size = new System.Drawing.Size(99, 20);
            this.msEmlakSahip.Text = "Emlak Sahipleri";
            this.msEmlakSahip.Click += new System.EventHandler(this.msEmlakSahip_Click);
            // 
            // msSatilik
            // 
            this.msSatilik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msSatilik.Name = "msSatilik";
            this.msSatilik.Size = new System.Drawing.Size(50, 20);
            this.msSatilik.Text = "Satılık";
            this.msSatilik.Click += new System.EventHandler(this.msSatilik_Click);
            // 
            // msKiralik
            // 
            this.msKiralik.Name = "msKiralik";
            this.msKiralik.Size = new System.Drawing.Size(51, 20);
            this.msKiralik.Text = "Kiralık";
            this.msKiralik.Click += new System.EventHandler(this.msKiralik_Click);
            // 
            // msHakkinda
            // 
            this.msHakkinda.Name = "msHakkinda";
            this.msHakkinda.Size = new System.Drawing.Size(69, 20);
            this.msHakkinda.Text = "Hakkında";
            this.msHakkinda.Click += new System.EventHandler(this.msHakkinda_Click);
            // 
            // msKapat
            // 
            this.msKapat.Name = "msKapat";
            this.msKapat.Size = new System.Drawing.Size(49, 20);
            this.msKapat.Text = "Kapat";
            this.msKapat.Click += new System.EventHandler(this.msKapat_Click);
            // 
            // Secim1_Konut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Secim1_Konut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlak Takip Programı";
            this.Load += new System.EventHandler(this.Secim1_Konut_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSatilik;
        private System.Windows.Forms.ToolStripMenuItem msKiralik;
        private System.Windows.Forms.ToolStripMenuItem msEmlakSahip;
        private System.Windows.Forms.ToolStripMenuItem msHakkinda;
        private System.Windows.Forms.ToolStripMenuItem msKapat;



    }
}