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
    public class KitaplarService : IKitaplarService
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

        public List<KitaplarDTO> KitaplarListesi(string baglantiCumlesi)
        {
            komut1 = komut.command(baglantiCumlesi);
            dr = komut1.ExecuteReader();
            List<KitaplarDTO> ogto = new List<KitaplarDTO>();
            while(dr.Read())
            {
                ogto.Add(new KitaplarDTO
                {

                    KitapKodu = dr["KitapKodu"].ToString(),

                    KitapAdı = dr["KitapAdı"].ToString(),

                    Yazar = dr["Yazar"].ToString(),

                    Tür = dr["Tür"].ToString(),

                    BasımTarihi = dr["BasımTarihi"].ToString(),

                    SayfaSayısı = dr["SayfaSayısı"].ToString(),
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
