using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arşiv_Odası_Projesi
{
    public partial class FrmEvrakKayit : Form
    {
        public FrmEvrakKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdEvrakListesi.DataSource = ds.Tables[0];
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
        private void FrmEvrakKayit_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblOda", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOdaAd.ValueMember = "Oda_ID";
            CmbOdaAd.DisplayMember = "Oda_Adi";
            CmbOdaAd.DataSource = dt;
            label12.Visible = false;
            PrgBarYukleme.Visible = false;
            verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID INNER JOIN TblEvrak ON TblDosya.Dosya_ID=TblEvrak.Dosya_ID");
            kayitsayisi();
        }

        private void CmbOdaAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = CmbOdaAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblBolum where Oda_ID = " + label9.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbBolumAd.ValueMember = "Bolum_ID";
            CmbBolumAd.DisplayMember = "Bolum_Adi";
            CmbBolumAd.DataSource = dt;
        }

        private void CmbOdaAd_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CmbBolumAd_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CmbRafAd_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CmbKlasorAd_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CmbDosyaAd_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblEvrak (Evrak_Adi,Evrak_Konusu,Dosya_ID,Klasor_ID,Raf_ID,Bolum_ID,Oda_ID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            if (CmbOdaAd.Text == "")
            {
                MessageBox.Show("Lütfen bir oda ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CmbBolumAd.Text == "")
            {
                MessageBox.Show("Lütfen bir bölüm ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CmbRafAd.Text == "")
            {
                MessageBox.Show("Lütfen bir raf ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CmbKlasorAd.Text == "")
            {
                MessageBox.Show("Lütfen bir klasör ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CmbDosyaAd.Text == "")
            {
                MessageBox.Show("Lütfen bir dosya ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtEvrakAd.Text == "")
            {
                MessageBox.Show("Evrak adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (RchtxtEvrakKonusu.Text == "")
            {
                MessageBox.Show("Evrak konusu boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    komut.Parameters.AddWithValue("@p3", CmbDosyaAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", CmbKlasorAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p5", CmbRafAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p6", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p7", CmbOdaAd.SelectedValue);
                    PrgBarYukleme.Value = 0;
                    PrgBarYukleme.Step = 1;
                    for (int i = 0; i <= 100; i++)
                    {
                        pictureBox1.Visible = true;
                        PrgBarYukleme.PerformStep();
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(30);
                        label12.Visible = true;
                        PrgBarYukleme.Visible = true;
                        BtnKaydet.Enabled = false;
                        menuStrip1.Enabled = false;
                        RchtxtEvrakKonusu.Enabled = false;
                        TxtEvrakAd.Enabled = false;
                        CmbOdaAd.Enabled = false;
                        CmbBolumAd.Enabled = false;
                        CmbRafAd.Enabled = false;
                        CmbKlasorAd.Enabled = false;
                        CmbDosyaAd.Enabled = false;                        
                    }
                    if (TxtEvrakAd.Text != "" && RchtxtEvrakKonusu.Text != "")
                    {
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Yeni evrak oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID INNER JOIN TblEvrak ON TblDosya.Dosya_ID=TblEvrak.Dosya_ID");
                        TxtEvrakAd.Clear();
                        RchtxtEvrakKonusu.Clear();
                        PrgBarYukleme.Value = 0;
                    }
                    label12.Visible = false;
                    PrgBarYukleme.Visible = false;
                    BtnKaydet.Enabled = true;
                    pictureBox1.Visible = false;
                    menuStrip1.Enabled = true;
                    RchtxtEvrakKonusu.Enabled = true;
                    TxtEvrakAd.Enabled = true;
                    CmbOdaAd.Enabled = true;
                    CmbBolumAd.Enabled = true;
                    CmbRafAd.Enabled = true;
                    CmbKlasorAd.Enabled = true;
                    CmbDosyaAd.Enabled = true;
                }                
            }
            kayitsayisi();
        }

        private void DtgrdEvrakListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtEvrakid.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtEvrakAd.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[1].Value.ToString();
                RchtxtEvrakKonusu.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[2].Value.ToString();
                CmbDosyaAd.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[3].Value.ToString();
                CmbKlasorAd.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[4].Value.ToString();
                CmbRafAd.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[5].Value.ToString();
                CmbBolumAd.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[6].Value.ToString();
                CmbOdaAd.Text = DtgrdEvrakListesi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void CmbOdaAd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblOda", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOdaAd.ValueMember = "Oda_ID";
            CmbOdaAd.DisplayMember = "Oda_Adi";
            CmbOdaAd.DataSource = dt;
        }

        private void CmbBolumAd_Click(object sender, EventArgs e)
        {

        }

        private void CmbBolumAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = CmbBolumAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblRaf where Bolum_ID = " + label9.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbRafAd.ValueMember = "Raf_ID";
            CmbRafAd.DisplayMember = "Raf_Adi";
            CmbRafAd.DataSource = dt;
        }

        private void GrpbxEvrakIslemleri_Enter(object sender, EventArgs e)
        {

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

        private void CmbRafAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = CmbRafAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblKlasor where Raf_ID = " + label9.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbKlasorAd.ValueMember = "Klasor_ID";
            CmbKlasorAd.DisplayMember = "Klasor_Adi";
            CmbKlasorAd.DataSource = dt;
        }

        private void CmbKlasorAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = CmbKlasorAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblDosya where Klasor_ID = " + label9.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDosyaAd.ValueMember = "Dosya_ID";
            CmbDosyaAd.DisplayMember = "Dosya_Adi";
            CmbDosyaAd.DataSource = dt;
        }
    }
}
