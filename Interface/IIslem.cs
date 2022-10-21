using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IIslem
    {
        int fiyat { get; set; } 

        void Hesaplama(int fiyat);

        int Vergi(int fiyat);

        void Ekdurumlar();
    }
}
