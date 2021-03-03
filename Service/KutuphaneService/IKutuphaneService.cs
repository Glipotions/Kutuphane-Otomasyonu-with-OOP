using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IKutuphaneService
    {
        void insert(string baglantiCumlesi);

        void delete(string baglantiCumlesi);

        void update(string baglantiCumlesi);
        List<KutuphaneDTO> kutuphaneListesi(string baglantiCumlesi);
    }
}
