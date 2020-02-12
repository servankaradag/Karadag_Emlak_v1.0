namespace Emlak_Takip_Programi
{
    partial class SecimEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecimEkrani));
            this.pcIkon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKonut = new System.Windows.Forms.Button();
            this.btnİsyeri = new System.Windows.Forms.Button();
            this.btnArsa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcIkon)).BeginInit();
            this.SuspendLayout();
            // 
            // pcIkon
            // 
            this.pcIkon.Image = ((System.Drawing.Image)(resources.GetObject("pcIkon.Image")));
            this.pcIkon.Location = new System.Drawing.Point(12, 12);
            this.pcIkon.Name = "pcIkon";
            this.pcIkon.Size = new System.Drawing.Size(256, 54);
            this.pcIkon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcIkon.TabIndex = 0;
            this.pcIkon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Başarılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen Seçiminizi Yapınız.";
            // 
            // btnKonut
            // 
            this.btnKonut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonut.ForeColor = System.Drawing.Color.Red;
            this.btnKonut.Location = new System.Drawing.Point(15, 121);
            this.btnKonut.Name = "btnKonut";
            this.btnKonut.Size = new System.Drawing.Size(253, 67);
            this.btnKonut.TabIndex = 3;
            this.btnKonut.Text = "Konut";
            this.btnKonut.UseVisualStyleBackColor = true;
            this.btnKonut.Click += new System.EventHandler(this.btnKonut_Click);
            // 
            // btnİsyeri
            // 
            this.btnİsyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİsyeri.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnİsyeri.Location = new System.Drawing.Point(15, 194);
            this.btnİsyeri.Name = "btnİsyeri";
            this.btnİsyeri.Size = new System.Drawing.Size(253, 67);
            this.btnİsyeri.TabIndex = 4;
            this.btnİsyeri.Text = "İşyeri";
            this.btnİsyeri.UseVisualStyleBackColor = true;
            this.btnİsyeri.Click += new System.EventHandler(this.btnİsyeri_Click);
            // 
            // btnArsa
            // 
            this.btnArsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArsa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnArsa.Location = new System.Drawing.Point(15, 267);
            this.btnArsa.Name = "btnArsa";
            this.btnArsa.Size = new System.Drawing.Size(253, 67);
            this.btnArsa.TabIndex = 5;
            this.btnArsa.Text = "Arsa";
            this.btnArsa.UseVisualStyleBackColor = true;
            this.btnArsa.Click += new System.EventHandler(this.btnArsa_Click);
            // 
            // SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.btnArsa);
            this.Controls.Add(this.btnİsyeri);
            this.Controls.Add(this.btnKonut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcIkon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlak Takip Programı";
            this.Load += new System.EventHandler(this.SecimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcIkon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcIkon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKonut;
        private System.Windows.Forms.Button btnİsyeri;
        private System.Windows.Forms.Button btnArsa;
    }
}