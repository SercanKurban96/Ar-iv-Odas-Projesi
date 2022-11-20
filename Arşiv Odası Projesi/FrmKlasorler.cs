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
    public partial class FrmKlasorler : Form
    {
        public FrmKlasorler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdKlasorler.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TblKlasor", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKayitSayisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmKlasorler_Load(object sender, EventArgs e)
        {
            TxtKlasorAd.Focus();
            SqlCommand komut = new SqlCommand("select * from TblOda", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOdaAd.ValueMember = "Oda_ID";
            CmbOdaAd.DisplayMember = "Oda_Adi";
            CmbOdaAd.DataSource = dt;
            verilerigoster("select Klasor_ID as 'Klasör ID',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID");
            kayitsayisi();
        }
        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(Klasor_Adi) from TblKlasor where Klasor_Adi= '" + TxtKlasorAd.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglanti().Close();
            return sonuc;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblKlasor (Klasor_Adi,Raf_ID,Bolum_ID,Oda_ID) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            if (CmbBolumAd.Text == "")
            {
                MessageBox.Show("Lütfen bir bölüm ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CmbRafAd.Text == "")
            {
                MessageBox.Show("Lütfen bir raf ismi ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtKlasorAd.Text == "")
            {
                MessageBox.Show("Klasör adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtKlasorAd.Text) != 0)
                {
                    MessageBox.Show(TxtKlasorAd.Text + " adında bir klasör zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtKlasorAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbRafAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", CmbOdaAd.SelectedValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Klasör eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Klasor_ID as 'Klasör ID',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID");
                    TxtKlasorid.Clear();
                    TxtKlasorAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    CmbRafAd.ResetText();
                    TxtKlasorAd.Focus();
                    kayitsayisi();
                }                
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblKlasor where Klasor_ID = @p1", bgl.baglanti());
            if (TxtKlasorAd.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir klasör ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen klasörü silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    komut.Parameters.AddWithValue("@p1", TxtKlasorid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Klasör silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Klasor_ID as 'Klasör ID',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID");
                    TxtKlasorid.Clear();
                    TxtKlasorAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    CmbRafAd.ResetText();
                    TxtKlasorAd.Focus();
                    kayitsayisi();
                }
            }            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblKlasor set Klasor_Adi=@p1,Raf_ID=@p2,Bolum_ID=@p3,Oda_ID=@p4 where Klasor_ID=@p5", bgl.baglanti());
            if (TxtKlasorAd.Text == "")
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir klasör ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtKlasorAd.Text) != 0)
                {
                    MessageBox.Show(TxtKlasorAd.Text + " adında bir klasör zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtKlasorAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbRafAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", CmbOdaAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p5", TxtKlasorid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Klasör güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Klasor_ID as 'Klasör ID',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID");
                    TxtKlasorid.Clear();
                    TxtKlasorAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    CmbRafAd.ResetText();
                    TxtKlasorAd.Focus();
                    kayitsayisi();
                }                
            }           
        }

        private void DtgrdKlasorler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtKlasorid.Text = DtgrdKlasorler.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtKlasorAd.Text = DtgrdKlasorler.Rows[e.RowIndex].Cells[1].Value.ToString();
                CmbRafAd.Text = DtgrdKlasorler.Rows[e.RowIndex].Cells[2].Value.ToString();
                CmbBolumAd.Text = DtgrdKlasorler.Rows[e.RowIndex].Cells[3].Value.ToString();
                CmbOdaAd.Text = DtgrdKlasorler.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void TxtKlasorAra_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select Klasor_ID as 'Klasör ID',Klasor_Adi as 'Klasör Adı',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID INNER JOIN TblKlasor ON TblRaf.Raf_ID=TblKlasor.Raf_ID where Klasor_Adi like '%" + TxtKlasorAra.Text+"%'");
        }

        private void CmbOdaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = CmbOdaAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblBolum where Oda_ID = " + label7.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbBolumAd.ValueMember = "Bolum_ID";
            CmbBolumAd.DisplayMember = "Bolum_Adi";
            CmbBolumAd.DataSource = dt;
        }

        private void CmbBolumid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = CmbBolumAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblRaf where Bolum_ID = " + label7.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbRafAd.ValueMember = "Raf_ID";
            CmbRafAd.DisplayMember = "Raf_Adi";
            CmbRafAd.DataSource = dt;
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
