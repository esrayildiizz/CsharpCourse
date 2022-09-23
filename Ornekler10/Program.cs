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

        public static void Secim2()
        {
            Console.WriteLine("****Orta Oda Seçenekleri****");
            Console.WriteLine("a-2 Kişilik Odalar");
            Console.WriteLine("b-2 Den Fazla Kişilik Odalar");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'a')
            {
                Console.WriteLine("Odanın günlük fiyatını girin");
                int fiyat= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yemek günde kaç öğün olsun?");
                int ydurum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Oda servisi olsun mu?");
                string odaservis = Console.ReadLine();
                Console.WriteLine("Yemek parası ne kadar?");
                int yparasi= Convert.ToInt32(Console.ReadLine());
                if (ydurum==3 &&( odaservis == "Evet" || odaservis == "evet"))
                {
                    int sonuc = fiyat + (3 * (yparasi)) + (fiyat * 7 / 100);
                    Console.WriteLine("Ödeyeceğiniz tutar: "+sonuc);
                }
                else if(ydurum==2 && odaservis == "Evet")
                {
                    int sonuc = fiyat + (2 * (yparasi)) + (fiyat * 2 / 100);
                    Console.WriteLine("Ödeyeceğiniz tutar: " + sonuc);
                }
                
            }
            else if (secim == 'b')
            {
                int ofiyat = 500;
                int yemek = 50;
                Console.WriteLine("Kaç kişi kalacaksınız?");
                int kisi= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Çocuk var mı?");
                string cvp= Console.ReadLine();
                if(cvp=="Evet" || cvp == "evet")
                {
                    Console.WriteLine("çocuk yaşı kaç?");
                    int cocuk = Convert.ToInt32(Console.ReadLine());
                    if (cocuk < 7)
                    {
                        Console.WriteLine(" 7 yaşından küçük çocuk için ücret alınmayacaktır.");
                    }
                    else 
                    {
                        int hesapla = (ofiyat + (3 * (yemek))) * kisi + (ofiyat * 3 / 100);
                        Console.WriteLine("Ödemeniz gereken tutar: " + hesapla);
                    }
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
                    Secim2();
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
