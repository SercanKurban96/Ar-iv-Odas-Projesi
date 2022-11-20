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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdOdalar.DataSource = ds.Tables[0];
        }

        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(Oda_Adi) from TblOda where Oda_Adi= '" + TxtOdaAd.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu,bgl.baglanti());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            bgl.baglanti().Close();
            return sonuc;
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TblOda", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKayitSayisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblOda (Oda_Adi) values (@p1)", bgl.baglanti());           
            if (TxtOdaAd.Text == "")
            {
                MessageBox.Show("Oda adı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtOdaAd.Text) != 0)
                {
                    MessageBox.Show(TxtOdaAd.Text + " adında bir oda zaten mevcut.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtOdaAd.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Oda eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Oda_ID as 'Oda ID', Oda_Adi as 'Oda Adı' from TblOda");
                    TxtOdaid.Clear();
                    TxtOdaAd.Clear();
                    TxtOdaAd.Focus();
                    kayitsayisi();
                }                
            }
        }

        private void DtgrdOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtOdaid.Text = DtgrdOdalar.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtOdaAd.Text = DtgrdOdalar.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblOda where Oda_ID=@p1", bgl.baglanti());
            if (TxtOdaAd.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir oda ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen odayı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    komut.Parameters.AddWithValue("@p1", TxtOdaid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Oda silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Oda_ID as 'Oda ID', Oda_Adi as 'Oda Adı' from TblOda");
                    TxtOdaid.Clear();
                    TxtOdaAd.Clear();
                    TxtOdaAd.Focus();
                    kayitsayisi();
                }
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblOda set Oda_Adi=@p1 where Oda_ID=@p2", bgl.baglanti());
            if (TxtOdaAd.Text == "")
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir oda ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtOdaAd.Text) != 0)
                {
                    MessageBox.Show(TxtOdaAd.Text + " adında bir oda zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p1", TxtOdaAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtOdaid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Oda güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select Oda_ID as 'Oda ID', Oda_Adi as 'Oda Adı' from TblOda");
                    TxtOdaid.Clear();
                    TxtOdaAd.Clear();
                    TxtOdaAd.Focus();
                    kayitsayisi();
                }                
            }
        }

        private void TxtOdaAra_TextChanged(object sender, EventArgs e)
        {
            verilerigoster("select Oda_ID as 'Oda ID', Oda_Adi as 'Oda Adı' from TblOda where Oda_Adi like '%" + TxtOdaAra.Text + "%'");
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            TxtOdaAd.Focus();
            verilerigoster("select Oda_ID as 'Oda ID', Oda_Adi as 'Oda Adı' from TblOda");
            kayitsayisi();
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
