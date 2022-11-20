namespace Arşiv_Odası_Projesi
{
    partial class FrmEvrakDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvrakDuzenle));
            this.BtnDuzenle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.RchtxtEvrakKonusu = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEvrakAd = new System.Windows.Forms.TextBox();
            this.DtgrdEvrakDuzenle = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEvrakid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEvrakAra = new System.Windows.Forms.TextBox();
            this.LblKarakter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdEvrakDuzenle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDuzenle.Location = new System.Drawing.Point(526, 274);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(105, 47);
            this.BtnDuzenle.TabIndex = 46;
            this.BtnDuzenle.Text = "Düzenle";
            this.BtnDuzenle.UseVisualStyleBackColor = false;
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Location = new System.Drawing.Point(137, 274);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 47);
            this.BtnSil.TabIndex = 45;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // RchtxtEvrakKonusu
            // 
            this.RchtxtEvrakKonusu.BackColor = System.Drawing.Color.MistyRose;
            this.RchtxtEvrakKonusu.Location = new System.Drawing.Point(137, 118);
            this.RchtxtEvrakKonusu.MaxLength = 2000;
            this.RchtxtEvrakKonusu.Name = "RchtxtEvrakKonusu";
            this.RchtxtEvrakKonusu.Size = new System.Drawing.Size(494, 150);
            this.RchtxtEvrakKonusu.TabIndex = 44;
            this.RchtxtEvrakKonusu.Text = "";
            this.RchtxtEvrakKonusu.TextChanged += new System.EventHandler(this.RchtxtEvrakKonusu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(20, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Evrak Konusu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(49, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Evrak Adı:";
            // 
            // TxtEvrakAd
            // 
            this.TxtEvrakAd.BackColor = System.Drawing.Color.MistyRose;
            this.TxtEvrakAd.Location = new System.Drawing.Point(137, 84);
            this.TxtEvrakAd.MaxLength = 100;
            this.TxtEvrakAd.Name = "TxtEvrakAd";
            this.TxtEvrakAd.Size = new System.Drawing.Size(494, 26);
            this.TxtEvrakAd.TabIndex = 40;
            // 
            // DtgrdEvrakDuzenle
            // 
            this.DtgrdEvrakDuzenle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdEvrakDuzenle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdEvrakDuzenle.Location = new System.Drawing.Point(-1, 347);
            this.DtgrdEvrakDuzenle.Name = "DtgrdEvrakDuzenle";
            this.DtgrdEvrakDuzenle.Size = new System.Drawing.Size(915, 174);
            this.DtgrdEvrakDuzenle.TabIndex = 6;
            this.DtgrdEvrakDuzenle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdEvrakDuzenle_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(930, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Evrak Adı:";
            this.label8.Visible = false;
            // 
            // TxtEvrakid
            // 
            this.TxtEvrakid.BackColor = System.Drawing.Color.MistyRose;
            this.TxtEvrakid.Location = new System.Drawing.Point(961, 242);
            this.TxtEvrakid.Name = "TxtEvrakid";
            this.TxtEvrakid.Size = new System.Drawing.Size(159, 26);
            this.TxtEvrakid.TabIndex = 42;
            this.TxtEvrakid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 44);
            this.label1.TabIndex = 49;
            this.label1.Text = "EVRAK DÜZENLEME ODASI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(650, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Evrak Ara:";
            // 
            // TxtEvrakAra
            // 
            this.TxtEvrakAra.BackColor = System.Drawing.Color.MistyRose;
            this.TxtEvrakAra.Location = new System.Drawing.Point(742, 166);
            this.TxtEvrakAra.Name = "TxtEvrakAra";
            this.TxtEvrakAra.Size = new System.Drawing.Size(163, 26);
            this.TxtEvrakAra.TabIndex = 50;
            this.TxtEvrakAra.TextChanged += new System.EventHandler(this.TxtEvrakAra_TextChanged);
            // 
            // LblKarakter
            // 
            this.LblKarakter.AutoSize = true;
            this.LblKarakter.BackColor = System.Drawing.Color.Transparent;
            this.LblKarakter.ForeColor = System.Drawing.Color.Lime;
            this.LblKarakter.Location = new System.Drawing.Point(637, 250);
            this.LblKarakter.Name = "LblKarakter";
            this.LblKarakter.Size = new System.Drawing.Size(18, 18);
            this.LblKarakter.TabIndex = 52;
            this.LblKarakter.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(680, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "/ 2000";
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
            this.menuStrip1.TabIndex = 54;
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
            this.LblKayitSayisi.ForeColor = System.Drawing.Color.Red;
            this.LblKayitSayisi.Location = new System.Drawing.Point(757, 315);
            this.LblKayitSayisi.Name = "LblKayitSayisi";
            this.LblKayitSayisi.Size = new System.Drawing.Size(18, 18);
            this.LblKayitSayisi.TabIndex = 64;
            this.LblKayitSayisi.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(650, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "Evrak Sayısı:";
            // 
            // FrmEvrakDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.LblKayitSayisi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblKarakter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEvrakAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDuzenle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RchtxtEvrakKonusu);
            this.Controls.Add(this.TxtEvrakid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtgrdEvrakDuzenle);
            this.Controls.Add(this.TxtEvrakAd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEvrakDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evrak Düzenle";
            this.Load += new System.EventHandler(this.FrmEvrakDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdEvrakDuzenle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDuzenle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.RichTextBox RchtxtEvrakKonusu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEvrakAd;
        private System.Windows.Forms.DataGridView DtgrdEvrakDuzenle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEvrakid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEvrakAra;
        private System.Windows.Forms.Label LblKarakter;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label13;
    }
}