using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
        //ornek1

        //Console.WriteLine("1 ile 7 arasında bir sayı giriniz: ");
        //int sayi = Convert.ToInt16(Console.ReadLine());

        //switch (sayi)
        //{

        //    case 1:
        //        Console.WriteLine("Gün=Pazartesi");
        //        break;
        //    case 2:
        //        Console.WriteLine("Gün=Salı");
        //        break;
        //    case 3:
        //        Console.WriteLine("Gün=Çarşamba");
        //        break;
        //    case 4:
        //        Console.WriteLine("Gün=Perşembe");
        //        break;
        //    case 5:
        //        Console.WriteLine("Gün=Cuma");
        //        break;
        //    case 6:
        //        Console.WriteLine("Gün=Cumartesi");
        //        break;
        //    case 7:
        //        Console.WriteLine("Gün=Pazar");
        //        break;
        //    default:
        //        Console.WriteLine("Hatalı Giriş Yptınız");
        //        break;

        //}

        //Console.ReadLine();







        //ornek2

        //Console.WriteLine("Burcunuzun Elementini Giriniz: ");
        //String burc = Convert.ToString(Console.ReadLine());

        //switch (burc)
        //{

        //    case "toprak":
        //        Console.WriteLine("boğa,başak,oğlak");
        //        Console.WriteLine("nur,zeynep");
        //        break;
        //    case "ateş":
        //        Console.WriteLine("yay,koç,aslan");
        //        Console.WriteLine("furkan,esra,gamze,alper");
        //        break;
        //    case "hava":
        //        Console.WriteLine("ikizler,terazi,kova");
        //        Console.WriteLine("aleyna,berkcan");
        //        break;
        //    case "su":
        //        Console.WriteLine("yengeç");
        //        Console.WriteLine("ali,ayşe");
        //        break;

        //    default:
        //        Console.WriteLine("Hatalı Giriş Yptınız Böyle Bir Burç Elementi Yok... ");
        //        break;

        //}

        //Console.ReadLine();






        //ornek3

            DON:
            Console.WriteLine("*****HESAP MAKİNESİ*****");
            
            Console.WriteLine("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hangi işlemi yapmak istersiniz?");
            Console.WriteLine("1-Topla:");
            Console.WriteLine("2-Çıkar:");
            Console.WriteLine("3-Çarp:");
            Console.WriteLine("4-Böl:");

            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    
                    int toplam = sayi1 + sayi2;
                    Console.WriteLine("Toplama Sonucunuz: " + toplam);
                    break;

                case 2:
                   
                    int cikarma = sayi1 - sayi2;
                    Console.WriteLine("Çıkarma Sonucunuz: " + cikarma);
                    break;

                case 3:
                   
                    int carpma = sayi1 * sayi2;
                    Console.WriteLine("Çarpma Sonucunuz: " + carpma);
                    break;

                case 4:
                    
                    int bolme = sayi1 / sayi2;
                    Console.WriteLine("Bölme Sonucunuz: " + bolme);
                    break;

                default:
                    Console.WriteLine("Böyle bir işlem seçeneği yok tekrar deneyiniz...");
                    Console.WriteLine("Devam etmek istiyorsanız e veya E giriniz....");
                    char devam = Convert.ToChar(Console.ReadLine());
                    if (devam == 'E' || devam=='e')
                    {
                        goto DON;
                    }

                    break; 

                  
            }

            Console.ReadLine();
























        }
    }
}
