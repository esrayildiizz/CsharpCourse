using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Araclar arac1 = new Araclar();

            arac1.marka = "hyundai";
            arac1.model = "i35";
            arac1.fiyat = 400000;
            arac1.vergiorani = 12.5d;
            double tutar = arac1.OTV(arac1.fiyat, arac1.vergiorani);
            Console.WriteLine("Araba fiyatı: "+tutar);

            Console.ReadLine();
        }
    }
}
