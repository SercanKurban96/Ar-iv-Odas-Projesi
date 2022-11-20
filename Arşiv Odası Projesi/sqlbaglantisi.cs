using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Arşiv_Odası_Projesi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-9H60TTH\\SERCANKURBAN;Initial Catalog=DbArsivOdasi;User ID=WebMobile_302; Password=webmobile.302");
            baglan.Open();
            return baglan;
        }
    }
}
