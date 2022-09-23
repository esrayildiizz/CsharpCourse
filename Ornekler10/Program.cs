using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler10
{
    class Program
    {

        public static void Secim1()
        {
            Console.WriteLine("Jakuzi ve Sauna İster misiniz?");
            string cevap1 = Console.ReadLine();
            if (cevap1 == "evet" || cevap1 == "Evet")
            {
               double fiyat = 2000;
               Console.WriteLine("Odanın Bir Günlük Fiyatı: "+fiyat+"TL'dir.");
               
                Console.WriteLine("Kaç gün kalacaksınız ");
                double gün = Convert.ToDouble(Console.ReadLine());

                if (gün <= 7)
                {
                    fiyat = fiyat * gün;
                    Console.WriteLine("Ödemeniz Gereken Tutar: " + fiyat);
                }
                else if (gün > 7)
                {
                    fiyat -= fiyat * 13 / 100;
                    Console.WriteLine("Ödemeniz Gereken Tutar: " + fiyat);
                }
            }
           
        }

        public static bool Git(string cevap)
        {
            if (cevap == "Evet" || cevap == "evet")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            don:
            Console.WriteLine("****TATİL SEÇENEKLERİ****");
            Console.WriteLine("1-Lux Odalar");
            Console.WriteLine("2-Orta Odalar");
            Console.WriteLine("3-Ekonomi Odalar");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("***Lux Odalar***");
                    Secim1();
                    break;

                case 2:
                    Console.WriteLine("***Orta Odalar***");

                    break;

                case 3:
                    Console.WriteLine("***Ekonomi Odalar***");
                  
                    break;

                default:
                    break;

            }
            Console.WriteLine("İşleme devam etmek ister misiniz?");
            string devam = Convert.ToString(Console.ReadLine());
            if (Git(devam) == true)
            {
                goto don;
            }
            else
            {
                Console.WriteLine("YALLAH");
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
