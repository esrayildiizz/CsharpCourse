using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler13
{
    class Program
    {
        static double fiyat = 0;
        static double tfiyat = 0;
        

        public static void Okul(double fiyat)
        {
       
            Console.WriteLine("****Seçenekleri****");
            Console.WriteLine("1-Kırtasiye Malzemeleri");
            Console.WriteLine("2-Ofis Gereçleri");
            Console.WriteLine("Seçmek istediğinizin kodunu yazın lütfen...");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1) //kırtasiye malzemeleri
            {
                Console.WriteLine("****Seçenekleri****");
                Console.WriteLine("1-Okul Gereçleri");
                Console.WriteLine("2-Toplu İşyeri Malzeme Alımı");
                Console.WriteLine("Seçmek istediğinizin kodunu yazın lütfen...");
                int secim1 = Convert.ToInt32(Console.ReadLine());
                if (secim1 == 1)
                {
                    Lise(fiyat);
                }
                else if (secim1 == 2)
                {
                    Miktar(fiyat);
                }

            }
            else if (secim == 2) //ofis gereçleri
            {
                Console.WriteLine("****Seçenekleri****");
                Console.WriteLine("1-Mobilya");
                Console.WriteLine("2-Sandalye");
                Console.WriteLine("3-Dosya evrak");
                Console.WriteLine("Seçmek istediğinizin kodunu yazın lütfen...");
                int secme= Convert.ToInt32(Console.ReadLine());
                if (secme == 1)
                {
                    Ofis(100, 5);
                }
                else if (secme == 2)
                {
                    Ofis(150, 6, 20);
                }
                else
                {
                    Ofis(50, 12, 25, 30);
                }


            }
        }

        public static void Ofis(int fiyat , int ürünadet)
        {
            int sonuc = fiyat * ürünadet;
            Console.WriteLine("Ödeyeceğiniz tutar: "+sonuc);
        }
        public static void Ofis(int fiyat, int ürünadet,int kdv)
        {
            int sonuc = (fiyat * ürünadet)+kdv;
            Console.WriteLine("Ödeyeceğiniz tutar: " + sonuc);
        }
        public static void Ofis(int fiyat, int ürünadet,int kdv,int ötv)
        {
            int sonuc = (fiyat * ürünadet)+kdv+ötv;
            Console.WriteLine("Ödeyeceğiniz tutar: " + sonuc);
        }

        public static void Lise(double fiyat)
        {
            Console.WriteLine("****Seçenekleri****");
            Console.WriteLine("1-Defter & Kalem Seti");
            Console.WriteLine("2-Yardımcı Kaynaklar Kitap Seti");
            Console.WriteLine("2-Müzik Aletleri");
            Console.WriteLine("Seçmek istediğinizin kodunu yazın lütfen...");
            int secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim2 == 1)
            {
                fiyat += 50.50d;
                double sonuc = Adet(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }
            else if (secim2 == 2)
            {
                fiyat += 100.50d;
                double sonuc = Adet(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }
            else if (secim2 == 3)
            {
                fiyat += 200.50d;
                double sonuc = Adet(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }

        }
        public static double Adet(double fiyat)
        {
            Console.WriteLine("Kaç adet almak istersiniz?");
            int adet = Convert.ToInt32(Console.ReadLine());
            if (adet > 5)
            {
                fiyat -= fiyat * 15 / 100;
                return fiyat;
            }
            else
            {
                fiyat -= fiyat * 5 / 100;
                return fiyat;
            }
        }

        public static void Miktar(double fiyat)
        {
            Console.WriteLine("Alacağınız ürün miktarını seçiniz...");
            Console.WriteLine("****Seçenekleri****");
            Console.WriteLine("1-Deste");
            Console.WriteLine("2-Düzine");
            int deste = 10;
            int duzine = 12;
            int sec = Convert.ToInt32(Console.ReadLine());
            if (sec == 1)
            {
                tfiyat += 10.50d;
                double ödeme= tfiyat * deste * (tfiyat * 20 / 100);
                Console.WriteLine("Ödeyeceğiniz tutar: " + ödeme);
            }
            else if (sec == 2)
            {
                tfiyat += 12.50d;
                double ödeme= tfiyat * duzine * (tfiyat * 15 / 100);
                Console.WriteLine("Ödeyeceğiniz tutar: " + ödeme);
            }
        }

            static void Main(string[] args)
        {
            Okul(fiyat);
            Console.ReadLine();
        }
    }
}
