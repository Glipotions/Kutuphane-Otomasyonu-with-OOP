using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Command
    {
        Baglanti baglanti = new Baglanti();

        public OleDbCommand command(string baglantiCumlesi)

        {
             
            OleDbCommand cmd = new OleDbCommand(baglantiCumlesi, baglanti.baglantı());
            return cmd;
        }

        //public SqlCommand command(string baglantiCumlesi)

        //{
        //    SqlCommand cmd = new SqlCommand(baglantiCumlesi, baglanti.baglantı());
        //    return cmd;
        //}
    }
}
