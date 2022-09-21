using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler5
{
    class Program
    {
        static void Main(string[] args)
        {
            //While döngüsü
            //ornek1

            //int sayi = 0;

            //while (sayi < 10)
            //{
            //    sayi++;
            //    Console.WriteLine("sayi: "+sayi);
            //}

            //Console.WriteLine("Döngü bitti");

            //Console.ReadLine();




            //ornek2

            //float sayi = 0;
            //float toplam = 0;
            //float ortalama = 0;

            //while (sayi < 10)
            //{
            //    sayi++;
            //    Console.WriteLine("sayi: " + sayi);
            //    toplam = toplam + sayi;
            //}


            //ortalama = toplam / 10;

            //Console.WriteLine("1 den 10 a kadar sayıların toplam: " + toplam);
            //Console.WriteLine("1 den 10 a kadar sayıların ortalaması: " + ortalama);

            //Console.ReadLine();






            //ornek3

            // 0 ile 100 arasındaki tek sayılarının çarpımını ve tek sayıları gösteren prog.

            //double sayi = 0;
            //double carpim = 1;
            //while (sayi < 100)
            //{
            //    if (sayi % 2 == 1)
            //    {

            //        Console.WriteLine("Tek sayılarımız: "+sayi);
            //        carpim = carpim * sayi;

            //    }

            //    sayi++;
            //}

            //Console.WriteLine("1 den 100 e kadar tek sayıların çarpımı: "+carpim);
            //Console.ReadLine();









            //ornek4
            //kira hesabını yapan prog.

            //int yil = 2005;
            //Console.WriteLine("Kira tutarınızı giriniz: ");
            //int kira = Convert.ToInt32(Console.ReadLine());
            //while (yil < 2015)
            //{
            //    yil++;
            //    kira = kira+(kira * 25 / 100);

            //    Console.WriteLine("yıl: "+yil +"  kira tutarı: "+kira);
            //}

            //Console.ReadLine();






            //ornek5

            //Console.WriteLine("Lütfen sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sayac = 0;
            //while (sayi %10>0)
            //{
            //    sayi = sayi / 10;
            //    sayac++;
            //}
            //Console.WriteLine("Girdiğiniz sayı "+sayac+" basamaklıdır.");
            //Console.ReadLine();









            //ornek6 

            //int sayi;
            //Console.WriteLine("Faktöriyeli alınacak sayıyı girin: ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //int faktoriyel = 1;

            //while (sayi >=1 )
            //{
            //    faktoriyel = faktoriyel * sayi;
            //    sayi--;
            //}

            //Console.WriteLine("SONUÇ: "+faktoriyel);
            //Console.ReadLine();









            //ornek7

            //klavyeden 15 girilene kadar sayıları toplayıp ekrana yazdıran prog.

            //int sayi = 0;
            //int toplam = 0;

            //while (sayi!=15)
            //{
            //    Console.WriteLine("Lütfen sayı giriniz: ");
            //    sayi= Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 15)
            //    {
            //        break;
            //    }

            //    toplam = toplam + sayi;
            //}

            //Console.WriteLine("Tebrikler 15 sayısını girdiniz...");
            //Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);


            //Console.ReadLine();




            //ornek8

            //klavyeden z karakteri girilene kadar tüm harfleri yan yana yazdıran prog.


            //string harf = "abcdefghijklmnoprstuvyz";
            //string birleştir = null;
            //while (harf != "z")
            //{
            //    Console.Write("Bir harf giriniz: ");
            //    harf = Convert.ToString(Console.ReadLine());
            //    birleştir += harf;
            //}

            //Console.WriteLine("Kelimeniz:" + birleştir);
            //Console.ReadLine();





            //ornek9
            //250 ile 1000 arasında  rastgele 10 çift sayının ekrana yazdırılması

            //Random rastgele = new Random();
            //int sayi;
            //int adet=0;

            //while (adet<=10)
            //{
            //    sayi = rastgele.Next(250, 1000);
            //    if (sayi % 2 == 0)
            //    {
            //        adet++;
            //        Console.WriteLine("Çift sayılarımız: "+sayi);
            //    }

            //}


            //Console.ReadLine();









            //ornek10


            //rastgele üretilen 1 ile 100 arasındaki sayıların toplamı 1000 i geçtiğinde sayıları ve toplamı yazan prog.

            //Random rastgele = new Random();

            //int toplam = 0;
            //int sayi ;

            //while (toplam < 1001)
            //{
            //   sayi = rastgele.Next(1, 100);
            //   toplam += sayi;
            //   Console.WriteLine("SAYI:"+sayi);

            //}
            //Console.WriteLine("SAYILARIN TOPLAMI: " + toplam);
            //Console.ReadLine();










            //ornek11

            //klavyeden girilen 1 ile 100 arasında tutulan sayının ,rastgele olarak tutulan
            //sayıların ikinci olarak kaç defada tutulduğunu bulan c# kodu (sayılar yan yana yazılacak)


            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Random rastgele = new Random();

            //int sayac1 = 0; 
            //int sayac2 = 0; //KAÇ ADIMDA BULDUĞUNU SAYMAK İÇİN

            //while (sayac1<2) // 2.DEFADA BULDUĞUNDA DURUCAK
            //{
            //    int rsayi = rastgele.Next(1, 100);
            //    Console.Write(rsayi+" ");
            //    sayac2++;

            //    if (sayi == rsayi)
            //    {
            //        sayac1++;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Sayı "+sayac2 +" defada bulundu.");

            //Console.ReadLine();








            //ornek12


            //int sayac = 0, top = 0, ort = 0;

            //do
            //{
            //    Console.Write("Öğrencinin notunu gir :");
            //    int not = Convert.ToInt32(Console.ReadLine());
            //    sayac += 1;
            //    top = top + not;

            //} while (sayac != 10);

            //ort = top / sayac;
            //Console.WriteLine("ortalama :" + ort);
            //Console.ReadLine();







            //ornek13



            //don:
            //    Console.Write("Sayı girin :");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int tek = 1;
            //    if (sayi == 0)
            //    {
            //        Console.WriteLine("Girilen sayı sıfırdır.");
            //        Console.WriteLine("Tekrar sayı giriniz...");
            //        goto don;
            //    }
            //    else
            //    {
            //        do
            //        {
            //            Console.WriteLine(tek);
            //            tek += 2;
            //        }
            //        while (tek < sayi);
            //    }


            //    Console.ReadLine();






            //ornek14

            //klavyeden sıfır sayısını girene kadar sayıların toplamını bulan prog.
            //int sayi = 0;
            //int adet = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı Giriniz :");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + sayi;
            //    adet++;
            //}
            //while (sayi != 0);

            //{
            //    Console.WriteLine("Girdiğiniz sayıların toplamı :" + toplam);
            //    toplam = toplam + sayi;
            //    adet++;
            //}
            //Console.ReadLine();









            //ornek15

            //int sifre = 0;
            //string nick = "";
            //int secim = 0;
            //Console.WriteLine("Kullanıcı adınızı giriniz");
            //nick = Console.ReadLine();
            //Console.WriteLine("Şifrenizi giriniz");
            //sifre = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    if (sifre == 1234)
            //    {
            //        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            //        Console.WriteLine("1-Kullanınıcı kaydı ekle");
            //        Console.WriteLine("2-Aktivasyon işlemi");
            //        secim = Convert.ToInt32(Console.ReadLine());
            //        if (secim == 1)
            //        {
            //            Console.WriteLine("Kullanıcı kaydı eklendi");
            //        }
            //        else if (secim == 2)
            //        {
            //            Console.WriteLine("Aktivasyon işlemi başarılı");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //        break;
            //    }
            //}
            //while (sifre != 1234);
            //Console.ReadLine();

























        }
    }
}
