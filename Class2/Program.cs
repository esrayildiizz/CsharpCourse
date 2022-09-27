using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();

            Console.WriteLine("Ürün nosu giriniz");
            urun1.UrunNo = Console.ReadLine();

            Console.WriteLine("Marka giriniz");
            urun1.Marka= Console.ReadLine();

            Console.WriteLine("Ürün numarası: "+urun1.UrunNo);
            Console.WriteLine("Ürün markası: "+urun1.Marka);


            double a = urun1.Tutar(1000, 18);
            Console.WriteLine("Tutar: "+a);
            Console.ReadLine();
        }
    }
}
