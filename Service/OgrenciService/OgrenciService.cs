using Data;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OgrenciService : IOgrenciService
    {
        Baglanti bgl = new Baglanti();

        Command komut = new Command();
        OleDbDataReader dr;
        OleDbCommand komut1;

        public void delete(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            komut1.ExecuteNonQuery();
        }
        public void insert(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            komut1.ExecuteNonQuery();
        }
        public void update(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            komut1.ExecuteNonQuery();
        }

        public List<OgrenciDTO> ogrenciListesi(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            dr = komut1.ExecuteReader();
            List<OgrenciDTO> ogto = new List<OgrenciDTO>();
            while(dr.Read())
            {
                ogto.Add(new OgrenciDTO
                {
                    Tc = dr["Tc"].ToString(),

                    Ad = dr["Ad"].ToString(),

                    Email = dr["Email"].ToString(),

                    Telefon = dr["Telefon"].ToString(),
                });
            }
            dr.Close();
            return ogto;
        }

        
    }
}
