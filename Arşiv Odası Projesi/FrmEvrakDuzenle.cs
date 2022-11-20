using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Arşiv_Odası_Projesi
{
    public partial class FrmEvrakDuzenle : Form
    {
        public FrmEvrakDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdEvrakDuzenle.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TblEvrak", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKayitSayisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblEvrak where Evrak_ID=@p1",bgl.baglanti());
            if (TxtEvrakAd.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir evrak ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen evrak kaydını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    komut.Parameters.AddWithValue("@p1", TxtEvrakid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Evrak kaydı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtEvrakAd.Clear();
                    RchtxtEvrakKonusu.Clear();
                }
                verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu' from TblEvrak");
            }
            kayitsayisi();
        }

        private void FrmEvrakDuzenle_Load(object sender, EventArgs e)
        {
            verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu' from TblEvrak");
            kayitsayisi();
        }
        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(Evrak_Adi) from TblEvrak where Evrak_Adi= '" + TxtEvrakAd.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglanti().Close();
            return sonuc;
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblEvrak set Evrak_Adi=@p1,Evrak_Konusu=@p2 where Evrak_ID=@p3",bgl.baglanti());
            if (TxtEvrakAd.Text == "")
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir evrak ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtEvrakAd.Text) != 0)
                {
                    MessageBox.Show(TxtEvrakAd.Text + " adında bir evrak zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtEvrakAd.Text);
                    komut.Parameters.AddWithValue("@p2", RchtxtEvrakKonusu.Text);
                    komut.Parameters.AddWithValue("@p3", TxtEvrakid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Evrak kaydı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu' from TblEvrak");
                    TxtEvrakAd.Clear();
                    RchtxtEvrakKonusu.Clear();
                }                
            }
            kayitsayisi();
        }

        private void DtgrdEvrakDuzenle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtEvrakid.Text = DtgrdEvrakDuzenle.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtEvrakAd.Text = DtgrdEvrakDuzenle.Rows[e.RowIndex].Cells[1].Value.ToString();
                RchtxtEvrakKonusu.Text = DtgrdEvrakDuzenle.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtEvrakAra_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu' from TblEvrak where Evrak_Adi like '%"+TxtEvrakAra.Text+"%'");
        }

        private void RchtxtEvrakKonusu_TextChanged(object sender, EventArgs e)
        {
            int sayi = RchtxtEvrakKonusu.TextLength;
            LblKarakter.Text = sayi.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmArsivOdasi fr = new FrmArsivOdasi();
            fr.Show();
            this.Hide();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniKayit fr = new FrmYeniKayit();
            fr.Show();
            this.Hide();
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

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arşiv Odası Projesi Sercan KURBAN tarafından hazırlanmıştır.", "Bilgi");
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
    }
}
