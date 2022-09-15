using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Ürün Bilgileri****");

            Console.WriteLine("Ürün fiyatı giriniz...");
            float fiyat = Convert.ToSingle(Console.ReadLine());

            if ( fiyat>100 && fiyat<200 )
            {
                Console.WriteLine("Ürün markası giriniz...");
                string marka= Convert.ToString(Console.ReadLine());
                if (marka == "Zara" || marka == "ZARA" || marka == "zara")
                {
                    fiyat += fiyat * 20 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar:"+fiyat);
                }
                else
                {
                    fiyat += fiyat * 10 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar:" + fiyat);
                }
            }
            else
            {
                fiyat += fiyat * 5 / 100;
                Console.WriteLine("Ödemeniz gereken tutar:" + fiyat);
            }

            Console.ReadLine();
        }
    }
}
