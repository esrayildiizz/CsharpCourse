using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler12
{
    class Program
    {
        static double fiyat = 0;

        public static void Kiyafet()
        {
            git:
            Console.WriteLine("****Kıyafet Seçenekleri****");
            Console.WriteLine("1-Etek");
            Console.WriteLine("2-Gömlek");
            Console.WriteLine("3-Pantolon");
            Console.WriteLine("Seçmek istediğiniz kıyafetin kodunu yazın lütfen...");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                fiyat += 100;
                Aksesuar(fiyat);
            }
            else if (secim == 2)
            {
                fiyat += 150;
                Aksesuar(fiyat);
            }
            else if (secim == 3)
            {
                fiyat += 200;
                Aksesuar(fiyat);
            }
            else
            {
                Console.WriteLine("ÜRÜN SEÇMEDİNİZ TEKRAR DENEYİNİZ...");
                goto git;
            }
        }

        public static void Aksesuar(double fiyat)
        {
            DON:
            Console.WriteLine("****Aksesuar Seçenekleri****");
            Console.WriteLine("1-Çanta");
            Console.WriteLine("2-Takı");
            Console.WriteLine("3-Kravat");
            Console.WriteLine("Seçmek istediğiniz aksesuar kodunu yazın lütfen...");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                fiyat += 80;
                Ayakkabi(fiyat);
            }
            else if (secim == 2)
            {
                fiyat += 50;
                Ayakkabi(fiyat);
            }
            else if (secim == 3)
            {
                fiyat += 75;
                Ayakkabi(fiyat);
            }
            else
            {
                Console.WriteLine("ÜRÜN SEÇMEDİNİZ TEKRAR DENEYİNİZ...");
                goto DON;
            }
        }
        public static void Ayakkabi(double fiyat)
        {
            don:
            Console.WriteLine("****Ayakkabı Seçenekleri****");
            Console.WriteLine("1-Spor");
            Console.WriteLine("2-Klasik");
            Console.WriteLine("3-Topuklu");
            Console.WriteLine("Seçmek istediğiniz ayakkabının kodunu yazın lütfen...");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                fiyat += 500.50d;
                double sonuc = Fis(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }
            else if (secim == 2)
            {
                fiyat += 650.50d;
                double sonuc = Fis(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }
            else if (secim == 3)
            {
                fiyat += 750.50d;
                double sonuc = Fis(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }
            else
            {
                Console.WriteLine("ÜRÜN SEÇMEDİNİZ TEKRAR DENEYİNİZ...");
                goto don;
            }
        }

        public static double Fis(double fiyat)
        {
            Console.WriteLine("Ödeme türü: 1-NAKİT  | 2-Kredi Kartı");
            string ödeme = Console.ReadLine();
            if (ödeme == "N")
            {
                fiyat -= fiyat * 1.5d / 100;
                return fiyat;
            }
            else
            {
                fiyat += fiyat * 1.5d / 100;
                return fiyat;
            }
        }
        static void Main(string[] args)
        {
            Kiyafet();
            Console.ReadLine();
        }
    }
}
