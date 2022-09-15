using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Esra";
            char karakter = '*';
            int yas = 24;
            float fiyat = 10.45f;
            float indirim = fiyat - fiyat * 20 / 100;

            Console.WriteLine("Müşteri Adı="+ad);
            Console.WriteLine("Sevdiği Karakter="+karakter);
            Console.WriteLine("Yaş="+yas);
            Console.WriteLine("Fiyat="+fiyat);
            Console.WriteLine(ad + " Müşterimizin Ödemesi Gereken Tutar="+indirim);
            Console.WriteLine("...İYİ GÜNLER DİLERİZ...");
            Console.ReadLine();
        }
    }
}
