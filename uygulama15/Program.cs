using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama15
{
    class Program
    {
        static void Main(string[] args)
        {
            //personel giriş yapabilsin kullanıcı adı ve şifre girerek
            //çocuk sayısını giriniz
            //medeni durum giriniz
            //eğer çocuk sayısı 2 den az ve medeni durumu bekar ise 
            //1-prim hesaplama
            //2-mesai hesaplama menüsü gelsin

            //eğer personel 1 seçerse maas istensin maasının %20 si prim verilsin
            //maas+primin %8 i kadarıda maasa agi eklensin

            //eğer 2 seçerse maas istensin mesai saati istensin
            //maas 10 binden az ve mesaisaati haftalık 60 saatten fazla ise 
            //maas+mesaisaati hesaplansın


            Console.WriteLine("***PERSONEL GİRİŞİ****");
            don:
            Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            string kadi = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Lütfen kullanıcı şifrenizi giriniz: ");
            int ksifre = Convert.ToInt32(Console.ReadLine());

            if(kadi=="esrayildiz" && ksifre == 12345)
            {
                Console.WriteLine("Lütfen çocuk sayınızı giriniz: ");
                int csayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen medeni durum giriniz: ");
                string mdurum= Convert.ToString(Console.ReadLine());

                if( csayi<2  &&( mdurum =="bekar" ||mdurum=="BEKAR" ||mdurum=="Bekar"))
                {
                    git:
                    Console.WriteLine("PRİM HESAPLAMA İÇİN (1) GİRİNİZ");
                    Console.WriteLine("MESAİ HESAPLAMA İÇİN (2) GİRİNİZ");
                    char secim = Convert.ToChar(Console.ReadLine());
                    if (secim == '1')
                    {
                        Console.WriteLine("Lütfen maaşınızı giriniz: ");
                        int maas= Convert.ToInt32(Console.ReadLine());
                        int prim = maas * 20 / 100;
                        Console.WriteLine("Prim Tutarınız: " +prim);
                        int agi = (maas + prim) * 8 / 100;
                        Console.WriteLine("Agi Tutarınız: "+agi);
                        int toplam = maas + agi;
                        Console.WriteLine("Maaş+agi toplamınız: "+toplam);
                        Console.WriteLine("İYİ GÜNLER DİLERİZ...");

                    }
                    else  if (secim == '2')
                    {
                        Console.WriteLine("Lütfen maaşınızı giriniz: ");
                        int maas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen  mesai saatinizi giriniz: ");
                        int msaati= Convert.ToInt32(Console.ReadLine());
                        if(maas<10000 && msaati > 60)
                        {
                            int toplam2 = maas +( msaati*7);
                            Console.WriteLine("Maaş ve mesai saatiniz toplamı: "+toplam2);
                            Console.WriteLine("İYİ GÜNLER DİLERİZ...");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz değerler hesaplama için uygun değildir.");
                            goto don;
                        }

                    }

                    else
                    {
                        Console.WriteLine("Yaptığınız seçim hatalı, tekrar deneyiniz...");
                        goto git;
                    }
                }
            }
            else
            {
                Console.WriteLine("Yanlış kullanıcı girişi yaptınız.Tekrar deneyiniz...");
                goto don;
            }

            Console.ReadLine();
        }
    }
}
