using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    class Program
    {
        static void Main(string[] args)
        {
            kardiyoloji h1 = new kardiyoloji();
            h1.Fiyat = 100;
            h1.durum = "Emekli";
            h1.Hemsire();
            int odeme =h1.MuayaneUcret(h1.Fiyat);
            Console.WriteLine("Katkı paylı ücret: "+h1.Katki(h1.durum,odeme));

            Console.ReadLine();
        }
    }
}
