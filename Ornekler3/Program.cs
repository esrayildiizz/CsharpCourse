using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü



            //ornek1

            //1 den  100 e kadar olan  sayıların toplamı 

            //int toplam = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    toplam += i;
            //}

            //Console.WriteLine("1 den 100 e kadar olan sayıların toplamı: "+toplam);

            //Console.ReadLine();





            //ornek2 

            //1 den 100 e kadar olan sayılardan çift olanların toplamı

            //int toplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam = toplam + i;

            //    }
            //}
            //Console.WriteLine("sonuç: "+toplam);
            //Console.ReadLine();



            //ornek3

            //int üs = 1;
            //int taban = 1;
            //int sonuc = 1;
            //Console.WriteLine("Taban  giriniz: ");
            //taban = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üs giriniz: ");
            //üs = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <=üs; i++)
            //{
            //    sonuc = sonuc * taban;
            //}

            //Console.WriteLine("Tabanı {0} ve kuvveti {1} olan sayının değeri= {2} ", taban,üs,sonuc);
            //Console.ReadLine();





            //ornek4

            //Console.WriteLine("Toplanıcak sayı adedini girin: ");
            //int sayiadet= Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i= 0; i<sayiadet; i++)
            //{

            //    Console.WriteLine(i+1+".Sayıyı giriniz: ");
            //    int sayi= Convert.ToInt32(Console.ReadLine());

            //    toplam = toplam + sayi;

            //}
            //Console.WriteLine(" Girilen Sayıların Toplamı : "+toplam);
            //Console.ReadLine();




            //ornek5
            // girilen 10 sayıdan 3 basamaklıları ayrı bir sayacta tutan ve geri kalanları toplayan program

            //Console.WriteLine("10 Adet Sayı Girin Lütfen: ");
            //int toplam = 0;
            //int sayac = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + 1 + ".Sayıyı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi > 99 && sayi < 1000)
            //    {
            //        sayac++;
            //    }
            //    else
            //    {
            //        toplam = toplam + sayi;

            //    }
            //}

            //Console.WriteLine("3 Basamaklı sayı adedi: " + sayac);
            //Console.WriteLine("Geri kalan sayıların toplamı: " + toplam);
            //Console.ReadLine();




            //ornek6

            //klavyeden girilen sayıya kadar olan tek sayıları ve çift sayıları ayrı ayrı toplayan ve tek adet çift adet sayısını veren program:

            Console.WriteLine("Kaç sayı gireceksiniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int tsayac = 0;
            int csayac = 0;
            int ttoplam = 0;
            int ctoplam = 0;
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(i + 1 + ".Sayıyı giriniz: ");
                int  sayii= Convert.ToInt32(Console.ReadLine());

                if (sayii%2==0)
                {
                   csayac++;
                    ctoplam = ctoplam + sayii;
                }
                else
                {
                    tsayac++;
                    ttoplam = ttoplam + sayii;
                }
            }

            Console.WriteLine("ÇİFT SAYI ADEDİ: "+csayac+ "ve ÇİFT SAYILARIN TOPLAMI: "+ctoplam);
            Console.WriteLine("TEK SAYI ADEDİ: "+tsayac+ "ve TEK SAYILARIN TOPLAMI: " + ttoplam);
            Console.ReadLine();







        }
    }
}
