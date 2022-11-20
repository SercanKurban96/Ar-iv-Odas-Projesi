namespace Arşiv_Odası_Projesi
{
    partial class FrmYeniKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKayit));
            this.label6 = new System.Windows.Forms.Label();
            this.LnkLblIptal = new System.Windows.Forms.LinkLabel();
            this.LnkLblKayitOl = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGuvenlikCevap = new System.Windows.Forms.TextBox();
            this.CmbGuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.TxtSifreTekrar = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kullanıcı Kayıt Formu";
            // 
            // LnkLblIptal
            // 
            this.LnkLblIptal.AutoSize = true;
            this.LnkLblIptal.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblIptal.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblIptal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblIptal.LinkColor = System.Drawing.Color.White;
            this.LnkLblIptal.Location = new System.Drawing.Point(273, 321);
            this.LnkLblIptal.Name = "LnkLblIptal";
            this.LnkLblIptal.Size = new System.Drawing.Size(63, 29);
            this.LnkLblIptal.TabIndex = 25;
            this.LnkLblIptal.TabStop = true;
            this.LnkLblIptal.Text = "İptal";
            this.LnkLblIptal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblIptal_LinkClicked);
            // 
            // LnkLblKayitOl
            // 
            this.LnkLblKayitOl.AutoSize = true;
            this.LnkLblKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblKayitOl.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblKayitOl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblKayitOl.LinkColor = System.Drawing.Color.White;
            this.LnkLblKayitOl.Location = new System.Drawing.Point(81, 321);
            this.LnkLblKayitOl.Name = "LnkLblKayitOl";
            this.LnkLblKayitOl.Size = new System.Drawing.Size(100, 29);
            this.LnkLblKayitOl.TabIndex = 24;
            this.LnkLblKayitOl.TabStop = true;
            this.LnkLblKayitOl.Text = "Kayıt Ol";
            this.LnkLblKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblKayitOl_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cevap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Güvenlik Sorusu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TxtGuvenlikCevap
            // 
            this.TxtGuvenlikCevap.Location = new System.Drawing.Point(119, 247);
            this.TxtGuvenlikCevap.MaxLength = 50;
            this.TxtGuvenlikCevap.Name = "TxtGuvenlikCevap";
            this.TxtGuvenlikCevap.Size = new System.Drawing.Size(317, 26);
            this.TxtGuvenlikCevap.TabIndex = 18;
            // 
            // CmbGuvenlikSorusu
            // 
            this.CmbGuvenlikSorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGuvenlikSorusu.FormattingEnabled = true;
            this.CmbGuvenlikSorusu.Items.AddRange(new object[] {
            "En sevdiğiniz renk nedir?",
            "İlkokul öğretmeninizin adı nedir?",
            "Annenizin doğum yeri neresidir?"});
            this.CmbGuvenlikSorusu.Location = new System.Drawing.Point(120, 208);
            this.CmbGuvenlikSorusu.Name = "CmbGuvenlikSorusu";
            this.CmbGuvenlikSorusu.Size = new System.Drawing.Size(316, 26);
            this.CmbGuvenlikSorusu.TabIndex = 17;
            // 
            // TxtSifreTekrar
            // 
            this.TxtSifreTekrar.Location = new System.Drawing.Point(119, 169);
            this.TxtSifreTekrar.MaxLength = 20;
            this.TxtSifreTekrar.Name = "TxtSifreTekrar";
            this.TxtSifreTekrar.Size = new System.Drawing.Size(317, 26);
            this.TxtSifreTekrar.TabIndex = 16;
            this.TxtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(119, 131);
            this.TxtSifre.MaxLength = 20;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(318, 26);
            this.TxtSifre.TabIndex = 15;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(119, 91);
            this.TxtKullaniciAdi.MaxLength = 50;
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(318, 26);
            this.TxtKullaniciAdi.TabIndex = 14;
            // 
            // FrmYeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LnkLblIptal);
            this.Controls.Add(this.LnkLblKayitOl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGuvenlikCevap);
            this.Controls.Add(this.CmbGuvenlikSorusu);
            this.Controls.Add(this.TxtSifreTekrar);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmYeniKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel LnkLblIptal;
        private System.Windows.Forms.LinkLabel LnkLblKayitOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGuvenlikCevap;
        private System.Windows.Forms.ComboBox CmbGuvenlikSorusu;
        private System.Windows.Forms.TextBox TxtSifreTekrar;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
    }
}