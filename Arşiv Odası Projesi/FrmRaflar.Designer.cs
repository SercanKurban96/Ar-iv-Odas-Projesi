namespace Arşiv_Odası_Projesi
{
    partial class FrmRaflar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaflar));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRafid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbOdaAd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBolumAd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRafAd = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.DtgrdRaflar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRafAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdRaflar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(922, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Raf ID:";
            this.label1.Visible = false;
            // 
            // TxtRafid
            // 
            this.TxtRafid.Enabled = false;
            this.TxtRafid.Location = new System.Drawing.Point(987, 77);
            this.TxtRafid.Name = "TxtRafid";
            this.TxtRafid.Size = new System.Drawing.Size(159, 26);
            this.TxtRafid.TabIndex = 15;
            this.TxtRafid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(131, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Oda Adı:";
            // 
            // CmbOdaAd
            // 
            this.CmbOdaAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOdaAd.FormattingEnabled = true;
            this.CmbOdaAd.Location = new System.Drawing.Point(206, 82);
            this.CmbOdaAd.Name = "CmbOdaAd";
            this.CmbOdaAd.Size = new System.Drawing.Size(159, 26);
            this.CmbOdaAd.TabIndex = 17;
            this.CmbOdaAd.SelectedIndexChanged += new System.EventHandler(this.CmbOdaid_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(115, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bölüm Adı:";
            // 
            // CmbBolumAd
            // 
            this.CmbBolumAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBolumAd.FormattingEnabled = true;
            this.CmbBolumAd.Location = new System.Drawing.Point(206, 114);
            this.CmbBolumAd.Name = "CmbBolumAd";
            this.CmbBolumAd.Size = new System.Drawing.Size(159, 26);
            this.CmbBolumAd.TabIndex = 19;
            this.CmbBolumAd.SelectedIndexChanged += new System.EventHandler(this.CmbBolumid_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(136, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Raf Adı:";
            // 
            // TxtRafAd
            // 
            this.TxtRafAd.BackColor = System.Drawing.Color.MistyRose;
            this.TxtRafAd.Location = new System.Drawing.Point(206, 146);
            this.TxtRafAd.MaxLength = 50;
            this.TxtRafAd.Name = "TxtRafAd";
            this.TxtRafAd.Size = new System.Drawing.Size(159, 26);
            this.TxtRafAd.TabIndex = 21;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Location = new System.Drawing.Point(620, 222);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 47);
            this.BtnGuncelle.TabIndex = 25;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Location = new System.Drawing.Point(409, 222);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 47);
            this.BtnSil.TabIndex = 24;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Location = new System.Drawing.Point(206, 222);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 47);
            this.BtnKaydet.TabIndex = 23;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // DtgrdRaflar
            // 
            this.DtgrdRaflar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdRaflar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdRaflar.Location = new System.Drawing.Point(0, 293);
            this.DtgrdRaflar.Name = "DtgrdRaflar";
            this.DtgrdRaflar.Size = new System.Drawing.Size(914, 164);
            this.DtgrdRaflar.TabIndex = 27;
            this.DtgrdRaflar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdRaflar_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(674, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Raf Ara:";
            // 
            // TxtRafAra
            // 
            this.TxtRafAra.BackColor = System.Drawing.Color.MistyRose;
            this.TxtRafAra.Location = new System.Drawing.Point(744, 146);
            this.TxtRafAra.Name = "TxtRafAra";
            this.TxtRafAra.Size = new System.Drawing.Size(159, 26);
            this.TxtRafAra.TabIndex = 28;
            this.TxtRafAra.TextChanged += new System.EventHandler(this.TxtRafAra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(330, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 44);
            this.label8.TabIndex = 51;
            this.label8.Text = "RAF İŞLEMLERİ";
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
            this.menuStrip1.TabIndex = 52;
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
            this.LblKayitSayisi.Location = new System.Drawing.Point(100, 262);
            this.LblKayitSayisi.Name = "LblKayitSayisi";
            this.LblKayitSayisi.Size = new System.Drawing.Size(18, 18);
            this.LblKayitSayisi.TabIndex = 56;
            this.LblKayitSayisi.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(12, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Raf Sayısı:";
            // 
            // FrmRaflar
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 457);
            this.Controls.Add(this.LblKayitSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRafAra);
            this.Controls.Add(this.DtgrdRaflar);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRafAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbOdaAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRafid);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRaflar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raflar";
            this.Load += new System.EventHandler(this.FrmRaflar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdRaflar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRafid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbOdaAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBolumAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRafAd;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridView DtgrdRaflar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRafAra;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label7;
    }
}