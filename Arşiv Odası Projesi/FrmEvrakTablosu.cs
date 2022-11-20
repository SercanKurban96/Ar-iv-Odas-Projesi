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
    public partial class FrmEvrakTablosu : Form
    {
        public FrmEvrakTablosu()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            da.Fill(ds);
            DtgrdEvrakTablosu.DataSource = ds.Tables[0];
        }

        private void FrmEvrakTablosu_Load(object sender, EventArgs e)
        {
            verilerigoster("select Evrak_ID as 'Evrak ID',Evrak_Adi as 'Evrak Adı',Evrak_Konusu as 'Evrak Konusu' from TblEvrak");
        }
    }
}
