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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdBolumler.DataSource = ds.Tables[0];
        }
        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(Bolum_Adi) from TblBolum where Bolum_Adi= '" + TxtBolumAd.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglanti().Close();
            return sonuc;
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TblBolum", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKayitSayisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblBolum (Bolum_Adi,Oda_ID) values (@p1,@p2)", bgl.baglanti());
            if (TxtBolumAd.Text == "")
            {
                MessageBox.Show("Bölüm adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtBolumAd.Text) != 0)
                {
                    MessageBox.Show(TxtBolumAd.Text + " adında bir bölüm zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbOdaAd.SelectedValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Bölüm eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Bolum_ID as 'Bölüm ID',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID");
                    TxtBolumid.Clear();
                    TxtBolumAd.Clear();
                    TxtBolumAd.Focus();
                    CmbOdaAd.ResetText();
                    kayitsayisi();
                }                
            }
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            TxtBolumAd.Focus();
            SqlCommand komut = new SqlCommand("select * from TblOda",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOdaAd.ValueMember = "Oda_ID";
            CmbOdaAd.DisplayMember = "Oda_Adi";
            CmbOdaAd.DataSource = dt;
            verilerigoster("select Bolum_ID as 'Bölüm ID',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID");
            kayitsayisi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblBolum where Bolum_ID=@p1", bgl.baglanti());
            if (TxtBolumAd.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir bölüm ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen bölümü silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    komut.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Bölüm silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Bolum_ID as 'Bölüm ID',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID");
                    TxtBolumid.Clear();
                    TxtBolumAd.Clear();
                    CmbOdaAd.ResetText();
                    TxtBolumAd.Focus();
                    kayitsayisi();
                }
            }            
        }

        private void DtgrdBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtBolumid.Text = DtgrdBolumler.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtBolumAd.Text = DtgrdBolumler.Rows[e.RowIndex].Cells[1].Value.ToString();
                CmbOdaAd.Text = DtgrdBolumler.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblBolum set Bolum_Adi=@p1 where Bolum_ID=@p2", bgl.baglanti());
            if (TxtBolumAd.Text == "")
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir bölüm ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtBolumAd.Text) != 0)
                {
                    MessageBox.Show(TxtBolumAd.Text + " adında bir bölüm zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Bölüm güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Bolum_ID as 'Bölüm ID',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID");
                    TxtBolumid.Clear();
                    TxtBolumAd.Clear();
                    CmbOdaAd.ResetText();
                    TxtBolumAd.Focus();
                    kayitsayisi();
                }                
            }           
        }

        private void TxtBolumAra_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select Bolum_ID as 'Bölüm ID',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID where Bolum_Adi like '%" + TxtBolumAra.Text + "%'");
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
