using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arşiv_Odası_Projesi
{
    public partial class FrmArsivOdasi : Form
    {
        public FrmArsivOdasi()
        {
            InitializeComponent();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            this.Hide();
        }

        private void bölümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
            this.Hide();
        }

        private void raflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaflar fr = new FrmRaflar();
            fr.Show();
            this.Hide();
        }

        private void klasörlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKlasorler fr = new FrmKlasorler();
            fr.Show();
            this.Hide();
        }

        private void dosyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDosyalar fr = new FrmDosyalar();
            fr.Show();
            this.Hide();
        }

        private void FrmArsivOdasi_Load(object sender, EventArgs e)
        {

        }

        private void evrakislemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void evrakKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEvrakKayit fr = new FrmEvrakKayit();
            fr.Show();
            this.Hide();
        }

        private void evrakDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEvrakDuzenle fr = new FrmEvrakDuzenle();
            fr.Show();
            this.Hide();
        }

        private void evrakTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEvrakTablosu fr = new FrmEvrakTablosu();
            fr.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Arşiv Odası Projesi Sercan KURBAN tarafından hazırlanmıştır.","Bilgi");
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz.", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        private void PctOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            this.Hide();
        }

        private void PctBolumler_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
            this.Hide();
        }

        private void PctRaflar_Click(object sender, EventArgs e)
        {
            FrmRaflar fr = new FrmRaflar();
            fr.Show();
            this.Hide();
        }

        private void PctKlasorler_Click(object sender, EventArgs e)
        {
            FrmKlasorler fr = new FrmKlasorler();
            fr.Show();
            this.Hide();
        }

        private void PctDosyalar_Click(object sender, EventArgs e)
        {
            FrmDosyalar fr = new FrmDosyalar();
            fr.Show();
            this.Hide();
        }

        private void PctEvrakKayit_Click(object sender, EventArgs e)
        {
            FrmEvrakKayit fr = new FrmEvrakKayit();
            fr.Show();
            this.Hide();
        }

        private void PctEvrakDuzenle_Click(object sender, EventArgs e)
        {
            FrmEvrakDuzenle fr = new FrmEvrakDuzenle();
            fr.Show();
            this.Hide();
        }

        private void PctEvrakTablosu_Click(object sender, EventArgs e)
        {
            FrmEvrakTablosu fr = new FrmEvrakTablosu();
            fr.Show();
        }

        private void PctYeniKayit_Click(object sender, EventArgs e)
        {
            FrmYeniKayit fr = new FrmYeniKayit();
            fr.Show();
            this.Hide();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniKayit fr = new FrmYeniKayit();
            fr.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmArsivOdasi fr = new FrmArsivOdasi();
            fr.Show();
            this.Hide();
        }
    }
}
