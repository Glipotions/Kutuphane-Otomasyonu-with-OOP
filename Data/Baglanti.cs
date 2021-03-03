using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Baglanti
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.accdb.mdb");
        public OleDbConnection baglantı()
        {
            baglan.Open();
            return baglan;
        }
        public OleDbConnection baglantiKapat()

        {
            baglan.Close();
            return baglan;
        }


        //SqlConnection baglan = new SqlConnection("Data Source =.; Initial Catalog = Kutuphane; Integrated Security = True");

        //public SqlConnection baglantı()
        //{

        //    baglan.Open();
        //    return baglan;
        //}
        //public SqlConnection baglantiKapat()

        //{

        //    baglan.Close();

        //    return baglan;
        //}



    }
}
