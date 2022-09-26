using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler11
{
    class Program
    {


        static double fiyat = 0;


        public static void Menu()
        {
            git:
            try
              {
            Console.WriteLine("****Yemek Seçenekleri****");
            Console.WriteLine("1-Çorba");
            Console.WriteLine("2-Pilav");
            Console.WriteLine("3-Makarna");
            Console.WriteLine("Seçmek istediğiniz yemeğin numarasını yazın lütfen...");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                fiyat += 18;
                icecek(fiyat);
            }
            else if (secim == 2)
            {
                fiyat += 25;
                icecek(fiyat);
             }
            else if(secim==3)
            {
                fiyat += 30;
                icecek(fiyat);
             }
            else
            {
                Console.WriteLine("ÜRÜN SEÇMEDİNİZ TEKRAR DENEYİNİZ...");
                goto git;
            }
              }
            catch
            {
                Console.WriteLine("Hata yakalandı...");
                Console.WriteLine("İşleme devam etmek ister misiniz?");
                string devam = Console.ReadLine();
                if(devam=="Evet" || devam == "evet")
                {
                    goto git;
                }
            }
        }



        public static void icecek(double fiyat)
        {
            don:
            Console.WriteLine("****İçecek Seçenekleri****");
            Console.WriteLine("1-Kola");
            Console.WriteLine("2-Su");
            Console.WriteLine("3-Ayran");
            int secim= Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                fiyat += 9.5d;
                double sonuc = Fis(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: "+sonuc);
            }
            else if (secim == 2)
            {
                fiyat += 4.5d;
                double sonuc = Fis(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
            }
            else if (secim == 3)
            {
                fiyat += 6.5d;
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

            //Hata yakalama try------>deneme anlamında bir hata olup olmadığına bakar eğer hata varsa bloktan çıkıp catch bloguna atar.
            // 2 türlü hata vardır.
            // derleme hatası
            // çalışma zamanı hatasıdır.
            // catch(yakalama): try da eğer hata ile karşılaştıysa direk catch düşer ve hatanın olduğunu belirtir.
            // finally hata oluşsada oluşmasada bloğa girer yazmasakta olur.
            Menu();
          
            Console.ReadLine();

        }
    }
}
