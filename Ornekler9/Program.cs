using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler9
{
    class Program
    {
        //metotlar devamı

        public static double İndirim(double fiyat,string cek)
        {
            if (cek == "var")
            {
                fiyat -= fiyat * 30 / 100;
                return fiyat;
            }
            else
            {
                fiyat -= fiyat * 5 / 100;
                return fiyat;
            }
        }

        public static double Zam(double fiyat)
        {
            fiyat += fiyat * 25 / 100;
            return fiyat;
        }


        public static void GirisE()
        {
            Console.WriteLine("İndirim ister misiniz?");
            string cevap1 = Console.ReadLine();
            if (cevap1 == "evet" || cevap1 == "Evet")
            {
                Console.WriteLine("Fiyat giriniz: ");
                double fiyat = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hediye çekiniz var mı?");
                string cek = Console.ReadLine();
                double fis = İndirim(fiyat, cek);
                Console.WriteLine("Ödemeniz gereken tutar: " + fis);
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
            Console.WriteLine("****ÜRÜN SEÇİNİZ****");
            Console.WriteLine("1-Pijama Takımı");
            Console.WriteLine("2-Çanta");
            Console.WriteLine("3-Ayakkabı");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                Console.WriteLine("***Pijama Takımları***");
                    GirisE();
                    break;
                case 2:
                    Console.WriteLine("***Çanta***");
                    Console.WriteLine("Fiyat giriniz: ");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Zamlı tutar: "+ Zam(fiyat)); 
                    break;
                case 3:
                    Console.WriteLine("***Ayakkabı***");
                    GirisE();
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
