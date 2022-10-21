using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Urunler : IIslem
    {
        public int fiyat { get ; set ; }

        public void Ekdurumlar()
        {
            Console.WriteLine("Ürünlerimizde zarardan biz sorumlu değiliz...");
            Console.WriteLine("Garanti süresi iki yıldır.");
        }

        public void Hesaplama(int fiyat)
        {
            int sontutar=Vergi(fiyat);
            sontutar += sontutar * 30 / 100;
            Console.WriteLine("Ödemeniz gereken tutar: "+ sontutar);
        }

        public int Vergi(int fiyat)
        {
            fiyat += fiyat * 18 / 100;
            return fiyat;   
        }
    }
}
