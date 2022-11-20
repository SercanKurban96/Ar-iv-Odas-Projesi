namespace Arşiv_Odası_Projesi
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.PctCikis = new System.Windows.Forms.PictureBox();
            this.LnkLblGirisYap = new System.Windows.Forms.LinkLabel();
            this.LnkLblTemizle = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LnklblKayitOl = new System.Windows.Forms.LinkLabel();
            this.ChkSifreGosterGizle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(145, 110);
            this.TxtKullaniciAdi.MaxLength = 50;
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(233, 26);
            this.TxtKullaniciAdi.TabIndex = 0;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(145, 142);
            this.TxtSifre.MaxLength = 20;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(233, 26);
            this.TxtSifre.TabIndex = 1;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // PctCikis
            // 
            this.PctCikis.Image = ((System.Drawing.Image)(resources.GetObject("PctCikis.Image")));
            this.PctCikis.Location = new System.Drawing.Point(437, 0);
            this.PctCikis.Name = "PctCikis";
            this.PctCikis.Size = new System.Drawing.Size(58, 53);
            this.PctCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctCikis.TabIndex = 6;
            this.PctCikis.TabStop = false;
            this.PctCikis.Click += new System.EventHandler(this.PctCikis_Click);
            this.PctCikis.MouseLeave += new System.EventHandler(this.PctCikis_MouseLeave);
            this.PctCikis.MouseHover += new System.EventHandler(this.PctCikis_MouseHover);
            // 
            // LnkLblGirisYap
            // 
            this.LnkLblGirisYap.AutoSize = true;
            this.LnkLblGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblGirisYap.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblGirisYap.LinkColor = System.Drawing.Color.White;
            this.LnkLblGirisYap.Location = new System.Drawing.Point(142, 183);
            this.LnkLblGirisYap.Name = "LnkLblGirisYap";
            this.LnkLblGirisYap.Size = new System.Drawing.Size(90, 18);
            this.LnkLblGirisYap.TabIndex = 2;
            this.LnkLblGirisYap.TabStop = true;
            this.LnkLblGirisYap.Text = "GİRİŞ YAP";
            this.LnkLblGirisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblGirisYap_LinkClicked);
            this.LnkLblGirisYap.MouseLeave += new System.EventHandler(this.LnkLblGirisYap_MouseLeave);
            this.LnkLblGirisYap.MouseHover += new System.EventHandler(this.LnkLblGirisYap_MouseHover);
            // 
            // LnkLblTemizle
            // 
            this.LnkLblTemizle.AutoSize = true;
            this.LnkLblTemizle.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblTemizle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblTemizle.LinkColor = System.Drawing.Color.White;
            this.LnkLblTemizle.Location = new System.Drawing.Point(273, 183);
            this.LnkLblTemizle.Name = "LnkLblTemizle";
            this.LnkLblTemizle.Size = new System.Drawing.Size(81, 18);
            this.LnkLblTemizle.TabIndex = 3;
            this.LnkLblTemizle.TabStop = true;
            this.LnkLblTemizle.Text = "TEMİZLE";
            this.LnkLblTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblTemizle_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(128, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ARŞİV ODASI PROJESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(148, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hesabın yok mu?";
            // 
            // LnklblKayitOl
            // 
            this.LnklblKayitOl.AutoSize = true;
            this.LnklblKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.LnklblKayitOl.Location = new System.Drawing.Point(284, 209);
            this.LnklblKayitOl.Name = "LnklblKayitOl";
            this.LnklblKayitOl.Size = new System.Drawing.Size(66, 18);
            this.LnklblKayitOl.TabIndex = 13;
            this.LnklblKayitOl.TabStop = true;
            this.LnklblKayitOl.Text = "Kayıt Ol";
            this.LnklblKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblKayitOl_LinkClicked);
            // 
            // ChkSifreGosterGizle
            // 
            this.ChkSifreGosterGizle.AutoSize = true;
            this.ChkSifreGosterGizle.BackColor = System.Drawing.Color.Transparent;
            this.ChkSifreGosterGizle.Location = new System.Drawing.Point(94, 232);
            this.ChkSifreGosterGizle.Name = "ChkSifreGosterGizle";
            this.ChkSifreGosterGizle.Size = new System.Drawing.Size(125, 22);
            this.ChkSifreGosterGizle.TabIndex = 14;
            this.ChkSifreGosterGizle.Text = "Şifreyi Göster";
            this.ChkSifreGosterGizle.UseVisualStyleBackColor = false;
            this.ChkSifreGosterGizle.CheckedChanged += new System.EventHandler(this.ChkSifreGosterGizle_CheckedChanged);
            // 
            // FrmKullaniciGirisi
            // 
            this.AcceptButton = this.LnkLblGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 313);
            this.Controls.Add(this.ChkSifreGosterGizle);
            this.Controls.Add(this.LnklblKayitOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LnkLblTemizle);
            this.Controls.Add(this.LnkLblGirisYap);
            this.Controls.Add(this.PctCikis);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.FrmKullaniciGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.PictureBox PctCikis;
        private System.Windows.Forms.LinkLabel LnkLblGirisYap;
        private System.Windows.Forms.LinkLabel LnkLblTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LnklblKayitOl;
        private System.Windows.Forms.CheckBox ChkSifreGosterGizle;
    }
}

