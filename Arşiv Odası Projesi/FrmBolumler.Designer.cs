namespace Arşiv_Odası_Projesi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.DtgrdBolumler = new System.Windows.Forms.DataGridView();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.CmbOdaAd = new System.Windows.Forms.ComboBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBolumAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasörlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakislemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblKayitSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdBolumler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgrdBolumler
            // 
            this.DtgrdBolumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdBolumler.Location = new System.Drawing.Point(0, 293);
            this.DtgrdBolumler.Name = "DtgrdBolumler";
            this.DtgrdBolumler.Size = new System.Drawing.Size(915, 164);
            this.DtgrdBolumler.TabIndex = 2;
            this.DtgrdBolumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdBolumler_CellClick);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Location = new System.Drawing.Point(199, 231);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 47);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.BackColor = System.Drawing.Color.MistyRose;
            this.TxtBolumAd.Location = new System.Drawing.Point(126, 112);
            this.TxtBolumAd.MaxLength = 50;
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(159, 26);
            this.TxtBolumAd.TabIndex = 9;
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Enabled = false;
            this.TxtBolumid.Location = new System.Drawing.Point(1015, 184);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(159, 26);
            this.TxtBolumid.TabIndex = 10;
            this.TxtBolumid.Visible = false;
            // 
            // CmbOdaAd
            // 
            this.CmbOdaAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOdaAd.FormattingEnabled = true;
            this.CmbOdaAd.Location = new System.Drawing.Point(126, 80);
            this.CmbOdaAd.Name = "CmbOdaAd";
            this.CmbOdaAd.Size = new System.Drawing.Size(159, 26);
            this.CmbOdaAd.TabIndex = 11;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Location = new System.Drawing.Point(399, 231);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 47);
            this.BtnSil.TabIndex = 12;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Location = new System.Drawing.Point(606, 231);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 47);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(929, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bölüm ID:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Oda Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bölüm Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(623, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bölüm Ara:";
            // 
            // TxtBolumAra
            // 
            this.TxtBolumAra.BackColor = System.Drawing.Color.MistyRose;
            this.TxtBolumAra.Location = new System.Drawing.Point(716, 108);
            this.TxtBolumAra.Name = "TxtBolumAra";
            this.TxtBolumAra.Size = new System.Drawing.Size(159, 26);
            this.TxtBolumAra.TabIndex = 19;
            this.TxtBolumAra.TextChanged += new System.EventHandler(this.TxtBolumAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(292, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 44);
            this.label8.TabIndex = 50;
            this.label8.Text = "BÖLÜM İŞLEMLERİ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odalarToolStripMenuItem,
            this.evrakislemleriToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.yeniKayıtToolStripMenuItem,
            this.odalarToolStripMenuItem1,
            this.bölümlerToolStripMenuItem,
            this.raflarToolStripMenuItem,
            this.klasörlerToolStripMenuItem,
            this.dosyalarToolStripMenuItem});
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.odalarToolStripMenuItem.Text = "Ana İşlemler";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem1.Text = "Arşiv Odası";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniKayıtToolStripMenuItem.Image")));
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // odalarToolStripMenuItem1
            // 
            this.odalarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("odalarToolStripMenuItem1.Image")));
            this.odalarToolStripMenuItem1.Name = "odalarToolStripMenuItem1";
            this.odalarToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.odalarToolStripMenuItem1.Text = "Oda İşlemleri";
            this.odalarToolStripMenuItem1.Click += new System.EventHandler(this.odalarToolStripMenuItem1_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bölümlerToolStripMenuItem.Image")));
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bölümlerToolStripMenuItem.Text = "Bölüm İşlemleri";
            this.bölümlerToolStripMenuItem.Click += new System.EventHandler(this.bölümlerToolStripMenuItem_Click);
            // 
            // raflarToolStripMenuItem
            // 
            this.raflarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raflarToolStripMenuItem.Image")));
            this.raflarToolStripMenuItem.Name = "raflarToolStripMenuItem";
            this.raflarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.raflarToolStripMenuItem.Text = "Raf İşlemleri";
            this.raflarToolStripMenuItem.Click += new System.EventHandler(this.raflarToolStripMenuItem_Click);
            // 
            // klasörlerToolStripMenuItem
            // 
            this.klasörlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("klasörlerToolStripMenuItem.Image")));
            this.klasörlerToolStripMenuItem.Name = "klasörlerToolStripMenuItem";
            this.klasörlerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.klasörlerToolStripMenuItem.Text = "Klasör İşlemleri";
            this.klasörlerToolStripMenuItem.Click += new System.EventHandler(this.klasörlerToolStripMenuItem_Click);
            // 
            // dosyalarToolStripMenuItem
            // 
            this.dosyalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyalarToolStripMenuItem.Image")));
            this.dosyalarToolStripMenuItem.Name = "dosyalarToolStripMenuItem";
            this.dosyalarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dosyalarToolStripMenuItem.Text = "Dosya İşlemleri";
            this.dosyalarToolStripMenuItem.Click += new System.EventHandler(this.dosyalarToolStripMenuItem_Click);
            // 
            // evrakislemleriToolStripMenuItem
            // 
            this.evrakislemleriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.evrakislemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evrakKayıtToolStripMenuItem,
            this.evrakDüzenleToolStripMenuItem,
            this.evrakTablosuToolStripMenuItem});
            this.evrakislemleriToolStripMenuItem.Name = "evrakislemleriToolStripMenuItem";
            this.evrakislemleriToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.evrakislemleriToolStripMenuItem.Text = "Evrak İşlemleri";
            // 
            // evrakKayıtToolStripMenuItem
            // 
            this.evrakKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("evrakKayıtToolStripMenuItem.Image")));
            this.evrakKayıtToolStripMenuItem.Name = "evrakKayıtToolStripMenuItem";
            this.evrakKayıtToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.evrakKayıtToolStripMenuItem.Text = "Evrak Oluştur";
            this.evrakKayıtToolStripMenuItem.Click += new System.EventHandler(this.evrakKayıtToolStripMenuItem_Click);
            // 
            // evrakDüzenleToolStripMenuItem
            // 
            this.evrakDüzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("evrakDüzenleToolStripMenuItem.Image")));
            this.evrakDüzenleToolStripMenuItem.Name = "evrakDüzenleToolStripMenuItem";
            this.evrakDüzenleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.evrakDüzenleToolStripMenuItem.Text = "Evrak Düzenle";
            this.evrakDüzenleToolStripMenuItem.Click += new System.EventHandler(this.evrakDüzenleToolStripMenuItem_Click);
            // 
            // evrakTablosuToolStripMenuItem
            // 
            this.evrakTablosuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("evrakTablosuToolStripMenuItem.Image")));
            this.evrakTablosuToolStripMenuItem.Name = "evrakTablosuToolStripMenuItem";
            this.evrakTablosuToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.evrakTablosuToolStripMenuItem.Text = "Evrak Tablosu";
            this.evrakTablosuToolStripMenuItem.Click += new System.EventHandler(this.evrakTablosuToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(54, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // LblKayitSayisi
            // 
            this.LblKayitSayisi.AutoSize = true;
            this.LblKayitSayisi.BackColor = System.Drawing.Color.Transparent;
            this.LblKayitSayisi.ForeColor = System.Drawing.Color.Yellow;
            this.LblKayitSayisi.Location = new System.Drawing.Point(121, 260);
            this.LblKayitSayisi.Name = "LblKayitSayisi";
            this.LblKayitSayisi.Size = new System.Drawing.Size(18, 18);
            this.LblKayitSayisi.TabIndex = 54;
            this.LblKayitSayisi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Bölüm Sayısı:";
            // 
            // FrmBolumler
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 457);
            this.Controls.Add(this.LblKayitSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBolumAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.CmbOdaAd);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.DtgrdBolumler);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdBolumler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgrdBolumler;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.ComboBox CmbOdaAd;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBolumAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raflarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasörlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakislemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.Label LblKayitSayisi;
        private System.Windows.Forms.Label label5;
    }
}