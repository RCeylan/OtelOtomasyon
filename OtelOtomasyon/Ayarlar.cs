using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OtelOtomasyon
{
    class Ayarlar
    {
        public static SqlConnection baglanti;

        public static void BaglantiAc()
        {
            baglanti = new SqlConnection("Data Source=PC\\SA; Initial Catalog=ders;User Id=SA; Password=1234;Integrated Security=true");
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

        }

        public static void BaglantiKapat()
        {
            baglanti.Close();
        }
    }
}
