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
    public partial class FrmKullaniciKayit : Form
    {
        public FrmKullaniciKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;
        void ayniKayitEngelleme()
        {
            SqlCommand komut = new SqlCommand("select * from TblKullaniciGirisi where Kullanici_Adi=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtKullaniciAdi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }

        private void LnkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblKullaniciGirisi (Kullanici_Adi,Sifre,Sifre_Tekrar,Guvenlik_Sorusu,Guvenlik_Cevap) Values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            if (TxtKullaniciAdi.Text == "" || TxtSifre.Text == "" || TxtSifreTekrar.Text == "" || CmbGuvenlikSorusu.Text == "" || TxtGuvenlikCevap.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (TxtSifre.Text != TxtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ayniKayitEngelleme();
                if (durum == true)
                {
                    komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                    komut.Parameters.AddWithValue("@p3", TxtSifreTekrar.Text);
                    komut.Parameters.AddWithValue("@p4", CmbGuvenlikSorusu.Text);
                    komut.Parameters.AddWithValue("@p5", TxtGuvenlikCevap.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt oluşturuldu, giriş ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmKullaniciGirisi fr = new FrmKullaniciGirisi();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(TxtKullaniciAdi.Text + " adında bir kullanıcı zaten var.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void LnkLblIptal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullaniciGirisi fr = new FrmKullaniciGirisi();
            fr.Show();
            this.Hide();
        }

        private void LnkLblIptal_MouseHover(object sender, EventArgs e)
        {
            LnkLblIptal.LinkColor = Color.Red;
        }

        private void LnkLblIptal_MouseLeave(object sender, EventArgs e)
        {
            LnkLblIptal.LinkColor = Color.White;
        }

        private void LnkLblKayitOl_MouseHover(object sender, EventArgs e)
        {
            LnkLblKayitOl.LinkColor = Color.Green;
        }

        private void LnkLblKayitOl_MouseLeave(object sender, EventArgs e)
        {
            LnkLblKayitOl.LinkColor = Color.White;
        }
    }
}
