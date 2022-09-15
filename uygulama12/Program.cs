using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama12
{
    class Program
    {
        static void Main(string[] args)
        {


        don:
            Console.WriteLine("1.Sayıyı Giriniz ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("1-Toplama Yap(+)");
            Console.WriteLine("2-Çıkarma Yap(-)");
            Console.WriteLine("3-Çarpma Yap(*)");
            Console.WriteLine("4-Sayıların Yüzde Toplamnı Yap(%)");
            Console.WriteLine("Seçiminizi Yapınız");
            char secim = Convert.ToChar(Console.ReadLine());

            if (secim == '+')
            {
                int toplam = sayi + sayi2;
                Console.WriteLine("Toplama Sonucu: " + toplam);
            }

            else if (secim == '-')
            {
                int cikarma = sayi - sayi2;
                Console.WriteLine("Çıkarma Sonucu: " + cikarma);
            }

            else if (secim == '*')
            {
                int carpma = sayi * sayi2;
                Console.WriteLine("Çarpma Sonucu: " + carpma);
            }
            else if (secim == '%')
            {
                int yüzdetoplam = (sayi * 20 / 100 + sayi2 * 20 / 100);
                Console.WriteLine("Yüzde Sonucu: " + yüzdetoplam);
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız tekrar deneyiniz");
                Console.WriteLine("İşleme devam etmek istersen 88 tuşuna basın");
                string devam = Console.ReadLine();
                if (devam == "88")
                {
                    goto don;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            Console.ReadLine();






        }
    }
}
