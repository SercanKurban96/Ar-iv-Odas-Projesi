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
    public partial class FrmDosyalar : Form
    {
        public FrmDosyalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdDosyalar.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TblDosya", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKayitSayisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmDosyalar_Load(object sender, EventArgs e)
        {
            TxtDosyaAd.Focus();
            SqlCommand komut = new SqlCommand("select * from TblOda", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOdaAd.ValueMember = "Oda_ID";
            CmbOdaAd.DisplayMember = "Oda_Adi";
            CmbOdaAd.DataSource = dt;
            verilerigoster("select Dosya_ID as 'Dosya ID',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID");
            kayitsayisi();
        }

        private void CmbOdaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = CmbOdaAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblBolum where Oda_ID = " + label8.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbBolumAd.ValueMember = "Bolum_ID";
            CmbBolumAd.DisplayMember = "Bolum_Adi";
            CmbBolumAd.DataSource = dt;
        }

        private void CmbBolumid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = CmbBolumAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblRaf where Bolum_ID = " + label8.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbRafAd.ValueMember = "Raf_ID";
            CmbRafAd.DisplayMember = "Raf_Adi";
            CmbRafAd.DataSource = dt;
        }

        private void CmbRafid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = CmbRafAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblKlasor where Raf_ID = " + label8.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbKlasorAd.ValueMember = "Klasor_ID";
            CmbKlasorAd.DisplayMember = "Klasor_Adi";
            CmbKlasorAd.DataSource = dt;
        }
        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(Dosya_Adi) from TblDosya where Dosya_Adi= '" + TxtDosyaAd.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglanti().Close();
            return sonuc;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDosya (Dosya_Adi,Klasor_ID,Raf_ID,Bolum_ID,Oda_ID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            if (CmbBolumAd.Text == "")
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
            else if (TxtDosyaAd.Text == "")
            {
                MessageBox.Show("Dosya adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtDosyaAd.Text) != 0)
                {
                    MessageBox.Show(TxtDosyaAd.Text + " adında bir dosya zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtDosyaAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbKlasorAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", CmbRafAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p5", CmbOdaAd.SelectedValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Dosya eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Dosya_ID as 'Dosya ID',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID");
                    TxtDosyaid.Clear();
                    TxtDosyaAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    CmbRafAd.ResetText();
                    CmbKlasorAd.ResetText();
                    TxtDosyaAd.Focus();
                    kayitsayisi();
                }               
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblDosya where Dosya_ID = @p1", bgl.baglanti());
            if (TxtDosyaAd.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir dosya ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen dosyayı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    komut.Parameters.AddWithValue("@p1", TxtDosyaid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Dosya silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Dosya_ID as 'Dosya ID',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID");
                    TxtDosyaid.Clear();
                    TxtDosyaAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    CmbRafAd.ResetText();
                    CmbKlasorAd.ResetText();
                    TxtDosyaAd.Focus();
                    kayitsayisi();
                }
            }            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblDosya set Dosya_Adi=@p1,Klasor_ID=@p2,Raf_ID=@p3,Bolum_ID=@p4,Oda_ID=@p5 where Dosya_ID=@p6", bgl.baglanti());
            if (TxtDosyaAd.Text == "")
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir dosya ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtDosyaAd.Text) != 0)
                {
                    MessageBox.Show(TxtDosyaAd.Text + " adında bir dosya zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtDosyaAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbKlasorAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", CmbRafAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p5", CmbOdaAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p6", TxtDosyaid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Dosya güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Dosya_ID as 'Dosya ID',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID");
                    TxtDosyaid.Clear();
                    TxtDosyaAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    CmbRafAd.ResetText();
                    CmbKlasorAd.ResetText();
                    TxtDosyaAd.Focus();
                    kayitsayisi();
                }                
            }            
        }

        private void DtgrdDosyalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtDosyaid.Text = DtgrdDosyalar.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtDosyaAd.Text = DtgrdDosyalar.Rows[e.RowIndex].Cells[1].Value.ToString();
                CmbKlasorAd.Text = DtgrdDosyalar.Rows[e.RowIndex].Cells[2].Value.ToString();
                CmbRafAd.Text = DtgrdDosyalar.Rows[e.RowIndex].Cells[3].Value.ToString();
                CmbBolumAd.Text = DtgrdDosyalar.Rows[e.RowIndex].Cells[4].Value.ToString();
                CmbOdaAd.Text = DtgrdDosyalar.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void TxtDosyaAra_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select Dosya_ID as 'Dosya ID',Dosya_Adi as 'Dosya Adı',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID INNER JOIN TblDosya ON TblKlasor.Klasor_ID=TblDosya.Klasor_ID where Dosya_Adi like '%" + TxtDosyaAra.Text + "%'");
        }

        private void CmbKlasorAd_SelectedIndexChanged(object sender, EventArgs e)
        {

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
