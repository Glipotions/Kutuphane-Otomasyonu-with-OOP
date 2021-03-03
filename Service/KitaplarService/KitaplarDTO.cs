using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class KitaplarDTO
    {
        public string KitapKodu { get; set; }

        public string KitapAdı { get; set; }

        public string Yazar { get; set; }

        public string Tür { get; set; }

        public string SayfaSayısı { get; set; }

        public string BasımTarihi { get; set; }
      
    }
}
