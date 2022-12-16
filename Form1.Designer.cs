
namespace Yon3Odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x2_lbl = new System.Windows.Forms.Label();
            this.x1_lbl = new System.Windows.Forms.Label();
            this.x1_txtbx = new System.Windows.Forms.TextBox();
            this.x2_txtbx = new System.Windows.Forms.TextBox();
            this.hspl_btn = new System.Windows.Forms.Button();
            this.snc_ekrn_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uyari_lbl = new System.Windows.Forms.Label();
            this.snc_lbl = new System.Windows.Forms.Label();
            this.bslk_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tmz_bttn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // x2_lbl
            // 
            this.x2_lbl.AutoSize = true;
            this.x2_lbl.Location = new System.Drawing.Point(164, 189);
            this.x2_lbl.Name = "x2_lbl";
            this.x2_lbl.Size = new System.Drawing.Size(210, 15);
            this.x2_lbl.TabIndex = 1;
            this.x2_lbl.Text = "X2 Değerini Giriniz (-2 ile 2 aralığında) :";
            // 
            // x1_lbl
            // 
            this.x1_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x1_lbl.AutoSize = true;
            this.x1_lbl.Location = new System.Drawing.Point(171, 143);
            this.x1_lbl.Name = "x1_lbl";
            this.x1_lbl.Size = new System.Drawing.Size(210, 15);
            this.x1_lbl.TabIndex = 3;
            this.x1_lbl.Text = "X1 Değerini Giriniz (-3 ile 3 aralığında) :";
            this.x1_lbl.Click += new System.EventHandler(this.x1_lbl_Click);
            // 
            // x1_txtbx
            // 
            this.x1_txtbx.Location = new System.Drawing.Point(380, 143);
            this.x1_txtbx.Name = "x1_txtbx";
            this.x1_txtbx.Size = new System.Drawing.Size(100, 23);
            this.x1_txtbx.TabIndex = 5;
            // 
            // x2_txtbx
            // 
            this.x2_txtbx.Location = new System.Drawing.Point(380, 186);
            this.x2_txtbx.Name = "x2_txtbx";
            this.x2_txtbx.Size = new System.Drawing.Size(100, 23);
            this.x2_txtbx.TabIndex = 6;
            // 
            // hspl_btn
            // 
            this.hspl_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.hspl_btn.Location = new System.Drawing.Point(380, 229);
            this.hspl_btn.Name = "hspl_btn";
            this.hspl_btn.Size = new System.Drawing.Size(98, 44);
            this.hspl_btn.TabIndex = 9;
            this.hspl_btn.Text = "Hesapla";
            this.hspl_btn.UseVisualStyleBackColor = true;
            this.hspl_btn.Click += new System.EventHandler(this.hspl_btn_Click);
            // 
            // snc_ekrn_lbl
            // 
            this.snc_ekrn_lbl.AutoSize = true;
            this.snc_ekrn_lbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.snc_ekrn_lbl.Location = new System.Drawing.Point(54, 18);
            this.snc_ekrn_lbl.Name = "snc_ekrn_lbl";
            this.snc_ekrn_lbl.Size = new System.Drawing.Size(406, 25);
            this.snc_ekrn_lbl.TabIndex = 16;
            this.snc_ekrn_lbl.Text = "Fonksiyonun Girilen Değerlere Göre Sonucu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uyari_lbl);
            this.panel1.Controls.Add(this.snc_lbl);
            this.panel1.Controls.Add(this.snc_ekrn_lbl);
            this.panel1.Location = new System.Drawing.Point(157, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 138);
            this.panel1.TabIndex = 17;
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.AutoSize = true;
            this.uyari_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uyari_lbl.Location = new System.Drawing.Point(72, 66);
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(0, 20);
            this.uyari_lbl.TabIndex = 18;
            // 
            // snc_lbl
            // 
            this.snc_lbl.AutoSize = true;
            this.snc_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snc_lbl.Location = new System.Drawing.Point(223, 66);
            this.snc_lbl.Name = "snc_lbl";
            this.snc_lbl.Size = new System.Drawing.Size(73, 20);
            this.snc_lbl.TabIndex = 17;
            this.snc_lbl.Text = "Label     1";
            // 
            // bslk_lbl
            // 
            this.bslk_lbl.AutoSize = true;
            this.bslk_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bslk_lbl.Location = new System.Drawing.Point(238, 28);
            this.bslk_lbl.Name = "bslk_lbl";
            this.bslk_lbl.Size = new System.Drawing.Size(333, 28);
            this.bslk_lbl.TabIndex = 18;
            this.bslk_lbl.Text = "Six Hump Camel Back Test Fonsiyonu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(677, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // tmz_bttn
            // 
            this.tmz_bttn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tmz_bttn.Location = new System.Drawing.Point(510, 229);
            this.tmz_bttn.Name = "tmz_bttn";
            this.tmz_bttn.Size = new System.Drawing.Size(98, 44);
            this.tmz_bttn.TabIndex = 21;
            this.tmz_bttn.Text = "Temizle";
            this.tmz_bttn.UseVisualStyleBackColor = true;
            this.tmz_bttn.Click += new System.EventHandler(this.tmz_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.tmz_bttn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bslk_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hspl_btn);
            this.Controls.Add(this.x2_txtbx);
            this.Controls.Add(this.x1_txtbx);
            this.Controls.Add(this.x1_lbl);
            this.Controls.Add(this.x2_lbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label x2_lbl;
        private System.Windows.Forms.Label x1_lbl;
        private System.Windows.Forms.TextBox x1_txtbx;
        private System.Windows.Forms.TextBox x2_txtbx;
        private System.Windows.Forms.Button hspl_btn;
        private System.Windows.Forms.Label snc_ekrn_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bslk_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label snc_lbl;
        private System.Windows.Forms.Label uyari_lbl;
        private System.Windows.Forms.Button tmz_bttn;
    }
}

