using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class KitapTeslimGecmisiDTO
    {
        public string TeslimAlmaTarihi { get; set; }

        public string TeslimEdilmeTarihi { get; set; }

        public string Tc { get; set; }

        public string Ad { get; set; }

        public string KitapKodu { get; set; }

        public string KitapAdı { get; set; }
    }
}
