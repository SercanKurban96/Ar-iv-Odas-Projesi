namespace Arşiv_Odası_Projesi
{
    partial class FrmEvrakTablosu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvrakTablosu));
            this.DtgrdEvrakTablosu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdEvrakTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgrdEvrakTablosu
            // 
            this.DtgrdEvrakTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdEvrakTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdEvrakTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdEvrakTablosu.Location = new System.Drawing.Point(0, 0);
            this.DtgrdEvrakTablosu.Name = "DtgrdEvrakTablosu";
            this.DtgrdEvrakTablosu.Size = new System.Drawing.Size(984, 461);
            this.DtgrdEvrakTablosu.TabIndex = 0;
            // 
            // FrmEvrakTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.DtgrdEvrakTablosu);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEvrakTablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evrak Tablosu";
            this.Load += new System.EventHandler(this.FrmEvrakTablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdEvrakTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgrdEvrakTablosu;
    }
}