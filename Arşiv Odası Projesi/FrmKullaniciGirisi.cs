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
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void PctCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {              
                Application.Exit();
            }
        }

        private void PctCikis_MouseHover(object sender, EventArgs e)
        {
            PctCikis.BackColor = Color.Red;
        }

        private void PctCikis_MouseLeave(object sender, EventArgs e)
        {
            PctCikis.BackColor = Color.Transparent;
        }

        private void FrmKullaniciGirisi_Load(object sender, EventArgs e)
        {
            PctCikis.BackColor = Color.Transparent;
        }

        private void LnkLblTemizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TxtKullaniciAdi.Clear();
            TxtSifre.Clear();
        }

        private void LnkLblGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblKullaniciGirisi where Kullanici_Adi=@p1 and Sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı, arşiv odasına yönlendiriliyorsunuz.","Hoş geldiniz",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmArsivOdasi fr = new FrmArsivOdasi();
                fr.Show();
                this.Hide();
            }
            else if (TxtKullaniciAdi.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnklblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullaniciKayit fr = new FrmKullaniciKayit();
            fr.Show();
            this.Hide();
        }

        private void LnkLblGirisYap_MouseHover(object sender, EventArgs e)
        {
            LnkLblGirisYap.LinkColor = Color.Red;
        }

        private void LnkLblGirisYap_MouseLeave(object sender, EventArgs e)
        {
            LnkLblGirisYap.LinkColor = Color.White;
        }

        private void ChkSifreGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar)
            {
                TxtSifre.UseSystemPasswordChar = false;
                ChkSifreGosterGizle.Text = "Şifreyi Gizle";
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
                ChkSifreGosterGizle.Text = "Şifreyi Göster";
            }
        }
    }
}
