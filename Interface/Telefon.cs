using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Telefon : Urunler, IDurum
    {
        public string marka { get ; set ; }
        public string model { get ; set ; }
        public int otv { get ; set; }

        public void OtvHesapla(int otv, int fiyat)
        {
            fiyat += fiyat * otv / 100;
            Console.WriteLine("Telefon tutarı: " +fiyat);
        }
    }
}
