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

            //Console.WriteLine("Kaç sayı gireceksiniz: ");
            //int adet = Convert.ToInt32(Console.ReadLine());
            //int tsayac = 0;
            //int csayac = 0;
            //int ttoplam = 0;
            //int ctoplam = 0;
            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine(i + 1 + ".Sayıyı giriniz: ");
            //    int  sayii= Convert.ToInt32(Console.ReadLine());

            //    if (sayii%2==0)
            //    {
            //       csayac++;
            //        ctoplam = ctoplam + sayii;
            //    }
            //    else
            //    {
            //        tsayac++;
            //        ttoplam = ttoplam + sayii;
            //    }
            //}

            //Console.WriteLine("ÇİFT SAYI ADEDİ: "+csayac+ "ve ÇİFT SAYILARIN TOPLAMI: "+ctoplam);
            //Console.WriteLine("TEK SAYI ADEDİ: "+tsayac+ "ve TEK SAYILARIN TOPLAMI: " + ttoplam);
            //Console.ReadLine();






            //ornek7

            //girilen sayının faktoriyelini alma prog.

            //Console.WriteLine("Faktöriyeli alınacak sayıyı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 1; i <=sayi; i++)
            //{
            //    sonuc = sonuc * i;

            //}

            //Console.WriteLine("sonuç: "+sonuc);
            //Console.ReadLine();




            //ornek8

            //1 den girilen sayıya kadar 7 ye tam bölünen sayıları sayan, toplamlarını hesaplayan ve bu sayıları ekrana yazdıran prog.


            //Console.WriteLine("Lütfen sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;
            //int toplam = 0;
            //for (int i =1 ; i < sayi; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sayac++;
            //        toplam = toplam + i;

            //    }
            //}
            //Console.WriteLine("1'DEN "+sayi+" SAYISINA KADAR 7'YE BÖLÜNEN SAYILAR VE TOPLAMI: ");
            //Console.WriteLine();
            //Console.WriteLine("7ye böünen sayılar: " + sayac);
            //Console.WriteLine("7ye bölünen sayıların toplamı: "+toplam);

            //Console.ReadLine();






            //ornek9

            //bir komisyoncu sattığı mallardan fiyatı 50tl ye kadar olanlardan %3 , daha fazla olanlardan ise %2 komisyon almaktadır.
            //klavyeden teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda toplam komisyonu ekrana yazdıran prog.

            //Console.WriteLine("***MAL FİYAT LİSTESİ***");
            //float toplamk = 0;
            //float komisyon1 = 0;
            //float komisyon2 = 0;
            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine(i + 1 + ".Mal Fiyatını Giriniz: ");
            //    float  malfiyat= Convert.ToSingle(Console.ReadLine());


            //    if (malfiyat < 50)
            //    {
            //        komisyon1 = malfiyat * 3 / 100;
            //        toplamk += komisyon1;
            //        Console.WriteLine(" MAL FİYAT<50 İÇİN KOMİSYON TUTARI: "+komisyon1);

            //    }
            //    else
            //    {
            //        komisyon2 = malfiyat * 2 / 100;
            //        toplamk += komisyon2;
            //        Console.WriteLine(" MAL FİYAT>50 İÇİN KOMİSYON TUTARI:" + komisyon2);

            //    }



            //}

            //Console.WriteLine();
            //Console.WriteLine("TOPLAM KOMİSYON TUTARI: " + toplamk);

            //Console.ReadLine();





            //ornek10


            //girilen 10 sayıyı toplayıp 5.sayıya bölen program


            //float toplam = 0;
            //float sonuc = 0;
            //float bölen = 1;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + 1 + ".Sayıyı Giriniz: ");
            //    float sayi = Convert.ToSingle(Console.ReadLine());

            //    toplam = toplam + sayi;

            //    if (i == 4)
            //    {
            //        sayi = bölen;
            //    }
            //}

            //sonuc = toplam / bölen;

            //Console.WriteLine("Girdiğiniz sayıların toplamı: "+toplam);
            //Console.WriteLine("Sayıların toplamının  5.sayıya bölümü: "+sonuc);


            //Console.ReadLine();





            //ornek11

            //Console.WriteLine("En Büyük Ve En Küçük Sayı Bulma");

            //int enbüyük = -999999;
            //int enkücük = 9999999;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + 1 + ".Sayıyı Giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi > enbüyük)
            //        enbüyük = sayi;

            //    else if (sayi < enkücük)
            //        enkücük = sayi;
            //}

            //Console.WriteLine("EN BÜYÜK SAYI:  "+enbüyük);
            //Console.WriteLine("EN KÜÇÜK SAYI: "+enkücük);

            //Console.ReadLine();




            //ornek12

            //random üretilecek sayıyı kullanıdan isteyen ve girilen sayı kadar random sayı üretip iki basamaklı ve üç basamaklıların adedini gösteren
            //diğerlerinin de 5 den küçük olanların toplamını gösteren program
            //random değerler 1 ve 1000 arasında olucak.


            //Console.WriteLine("Kaç sayı üretilsin?");
            //int adet = Convert.ToInt32(Console.ReadLine());
            //Random rastgele = new Random(adet);


            //int iadet = 0;
            //int üadet = 0;
            //int toplam = 0;

            //for (int i = 0; i < adet; i++)
            //{
            //    int sayi = rastgele.Next(0, 1000);
            //    Console.WriteLine(sayi);
            //    if (sayi < 100 && sayi > 9)
            //    {
            //        iadet++;
            //    }
            //    else if (sayi < 1000 && sayi > 99)
            //    {
            //        üadet++;
            //    }

            //    else if (sayi < 5)
            //    {
            //        toplam = toplam + sayi;
            //    }
            //}


            //Console.WriteLine("İki basamaklı sayıların adedi: "+iadet);
            //Console.WriteLine("Üç basamaklı sayıların adedi: "+üadet);
            //Console.WriteLine("5 den küçük sayıların toplamı: "+toplam);

            //Console.ReadLine();






            //ornek13

            //Console.WriteLine("Bir sayı giriniz?");
            //int sayi= Convert.ToInt32(Console.ReadLine());

            //int carpim = 1;

            //for (int i = 1; i < sayi+1; i++)
            //{
            //    carpim = i * (i+1);
            //    Console.WriteLine("Sonuç:"+i+"x"+(i+1)+"="+carpim);
            //}


            //Console.ReadLine();







            //ornek14


            Console.WriteLine("Sayı girin lütfen: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int kontrol = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    kontrol++;
            }

            if (kontrol != 0)
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir....");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı asaldır...");
            }

            Console.ReadLine();



















        }
    }
}
