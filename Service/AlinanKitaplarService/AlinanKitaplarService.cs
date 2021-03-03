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
    public class AlinanKitaplarService : IAlinanKitaplarService
    {
        Baglanti bgl = new Baglanti();
        Command komut = new Command();
        OleDbDataReader dr;
        OleDbCommand komut1;

        //SqlDataReader dr;
        //SqlCommand komut1;
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

        public List<AlinanKitaplarDTO> AlinanKitaplarListesi(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            dr = komut1.ExecuteReader();
            List<AlinanKitaplarDTO> ogto = new List<AlinanKitaplarDTO>();
            while(dr.Read())
            {
                ogto.Add(new AlinanKitaplarDTO
                {
                    TeslimEdilenTarih = dr["TeslimEdilenTarih"].ToString(),

                    Tc = dr["Tc"].ToString(),

                    Ad = dr["Ad"].ToString(),

                    KitapKodu = dr["KitapKodu"].ToString(),

                    KitapAdı = dr["KitapAdı"].ToString(),
                });
            }
            
            return ogto;
        }

        public void update(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            komut1.ExecuteNonQuery();
        }
    }
}
