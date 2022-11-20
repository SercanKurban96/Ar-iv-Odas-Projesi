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
    public partial class FrmRaflar : Form
    {
        public FrmRaflar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdRaflar.DataSource = ds.Tables[0];
        }

        private void FrmRaflar_Load(object sender, EventArgs e)
        {
            TxtRafAd.Focus();
            SqlCommand komut = new SqlCommand("select * from TblOda", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOdaAd.ValueMember = "Oda_ID";
            CmbOdaAd.DisplayMember = "Oda_Adi";
            CmbOdaAd.DataSource = dt;
            verilerigoster("select Raf_ID as 'Raf ID',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID");
            kayitsayisi();
        }

        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(Raf_Adi) from TblRaf where Raf_Adi= '" + TxtRafAd.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglanti().Close();
            return sonuc;
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TblRaf", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKayitSayisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblRaf (Raf_Adi,Bolum_ID,Oda_ID) values (@p1,@p2,@p3)", bgl.baglanti());
            if (CmbBolumAd.Text == "")
            {
                MessageBox.Show("Lütfen bir bölüm ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtRafAd.Text == "")
            {
                MessageBox.Show("Raf adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtRafAd.Text) != 0)
                {
                    MessageBox.Show(TxtRafAd.Text + " adında bir raf zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtRafAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", CmbOdaAd.SelectedValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Raf eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Raf_ID as 'Raf ID',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID");
                    TxtRafid.Clear();
                    TxtRafAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    TxtRafAd.Focus();
                    kayitsayisi();
                }               
            }
        }

        private void DtgrdRaflar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtRafid.Text = DtgrdRaflar.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtRafAd.Text = DtgrdRaflar.Rows[e.RowIndex].Cells[1].Value.ToString();
                CmbBolumAd.Text = DtgrdRaflar.Rows[e.RowIndex].Cells[2].Value.ToString();
                CmbOdaAd.Text = DtgrdRaflar.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void TxtRafAra_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select Raf_ID as 'Raf ID',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID where Raf_Adi like '%" + TxtRafAra.Text+"%'");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblRaf where Raf_ID = @p1",bgl.baglanti());
            if (TxtRafAd.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir raf ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen rafı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    komut.Parameters.AddWithValue("@p1", TxtRafid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Raf silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Raf_ID as 'Raf ID',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID");
                    TxtRafid.Clear();
                    TxtRafAd.Clear();
                    CmbOdaAd.ResetText();
                    CmbBolumAd.ResetText();
                    TxtRafAd.Focus();
                    kayitsayisi();
                }
            }            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblRaf set Raf_Adi=@p1,Bolum_ID=@p2,Oda_ID=@p3 where Raf_ID=@p4", bgl.baglanti());
            if (TxtRafAd.Text == "")
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir raf ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtRafAd.Text) != 0)
                {
                    MessageBox.Show(TxtRafAd.Text + " adında bir raf zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtRafAd.Text);
                    komut.Parameters.AddWithValue("@p2", CmbBolumAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", CmbOdaAd.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", TxtRafid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Raf güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Raf_ID as 'Raf ID',Raf_Adi as 'Raf Adı',Bolum_Adi as 'Bölüm Adı',Oda_Adi as 'Oda Adı' from TblOda INNER JOIN TblBolum ON TblOda.Oda_ID=TblBolum.Oda_ID INNER JOIN TblRaf ON TblBolum.Bolum_ID=TblRaf.Bolum_ID");
                    TxtRafid.Clear();
                    TxtRafAd.Clear();
                    CmbBolumAd.ResetText();
                    CmbOdaAd.ResetText();
                    TxtRafAd.Focus();
                    kayitsayisi();
                }               
            }           
        }

        private void CmbOdaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = CmbOdaAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("select * from TblBolum where Oda_ID = " + label6.Text, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbBolumAd.ValueMember = "Bolum_ID";
            CmbBolumAd.DisplayMember = "Bolum_Adi";
            CmbBolumAd.DataSource = dt;
        }

        private void CmbBolumid_SelectedIndexChanged(object sender, EventArgs e)
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
