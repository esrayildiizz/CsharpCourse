using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama14
{
    class Program
    {
        static void Main(string[] args)
        {
            DON:
            Console.WriteLine("***ALAN HESAPLAMA EKRANI***");
            Console.WriteLine();
            Console.WriteLine("HANGİ GEOMETRİK ŞEKLİN HESAPLAMASINI YAPMAK İSTERSİN???");
            Console.WriteLine();
            Console.WriteLine("**SEÇENEKLER**");
            Console.WriteLine("DAİRE HESAPLAMA İÇİN (1) GİRİNİZ");
            Console.WriteLine("KARE HESAPLAMA İÇİN (2) GİRİNİZ");
            Console.WriteLine("DİKDÖRTGEN HESAPLAMA İÇİN (3) GİRİNİZ");

            char secim = Convert.ToChar(Console.ReadLine());

            if (secim == '1')
            {
                Console.WriteLine("****Daire Hesaplama****");
                Console.WriteLine("Dairenin Alanı Hesaplamak İçin (a) Giriniz:");
                Console.WriteLine("Dairenin Çevresini Hesaplamak İçin (b) Giriniz:");

                char karakter = Convert.ToChar(Console.ReadLine());
                if (karakter == 'a')
                {
                    Console.WriteLine("Dairenin yarıçapını giriniz: ");
                    float yaricap = Convert.ToSingle(Console.ReadLine());
                    float pi = 3.14f;
                    float dairealan = (pi * yaricap * yaricap);
                    Console.WriteLine("Dairenin alanı: " + dairealan);
                }
                else 
                {
                    Console.WriteLine("Dairenin yarıçapını giriniz: ");
                    float yaricap = Convert.ToSingle(Console.ReadLine());
                    float pi = 3.14f;
                    float dairecevre = (2 * pi * yaricap);
                    Console.WriteLine("Dairenin Çevresi: " + dairecevre);
                }
            }
            else if (secim == '2')
            {
                Console.WriteLine("****Kare Hesaplama****");
                Console.WriteLine("KARENİN BİR KENARINI UZUNLUĞU GİRİNİZ...");
                int kenar = Convert.ToInt32(Console.ReadLine());

                int karealan = kenar * kenar;
                Console.WriteLine("KARENİN ALANI: " +karealan);
                int karecevre = 2 * (kenar * kenar);
                Console.WriteLine("KARENİN ÇEVRESİ: " +karecevre);
            }
            else if (secim == '3')
            {
                Console.WriteLine("****Dikdörtgen Hesaplama****");
                Console.WriteLine("DİKDÖRTGENİN KISA KENARINI UZUNLUĞU GİRİNİZ...");
                int kısakenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("DİKDÖRTGENİN UZUN KENARINI UZUNLUĞU GİRİNİZ...");
                int uzunkenar = Convert.ToInt32(Console.ReadLine());

                int dikdörtgenalan = kısakenar * uzunkenar;
                Console.WriteLine("DİKDÖRTGENİN ALANI: " + dikdörtgenalan);
                int dikdörtgencevre = 2 * (kısakenar * uzunkenar);
                Console.WriteLine("KARENİN ÇEVRESİ: " + dikdörtgencevre);
            }

        
            else
            {
                Console.WriteLine("HATALI GİRİŞ YAPTINIZ , TEKRAR DENEYİNİZ");
                goto DON;
            }

           

            Console.ReadLine();
        }
    }
}
