using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama13
{
    class Program
    {
        static void Main(string[] args)
        {

            //random rastgele sayı üretme classı
            //fb gs macı skora göre kazananı gösteren program

            //ORNEK1


            //Random rastgele = new Random();
            //int skor = rastgele.Next(0, 3);
            //if (skor == 0)
            //{
            //    Console.WriteLine("Berabere kaldınız..." + "SKOR:" +skor);
            //}
            //else if (skor == 1)
            //{
            //    Console.WriteLine("GS kazandı..." + "SKOR: " +skor);
            //}
            //else if (skor == 2)
            //{
            //    Console.WriteLine("FB kazandı..." + "SKOR:" +skor);
            //}

            //Console.ReadLine();



            //ORNEK2

            //Random rastgele = new Random();
            //int tahminisayi = rastgele.Next(1, 11);
            //int adim = 0;
            //don:
            //Console.WriteLine("****Sayıyı Tahmin Etme Oyunu****");
            //Console.WriteLine("Lütfen 1 ile 10 Arasında Sayı Giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //adim++;

            //if(tahminisayi<sayi)
            //{
            //    Console.WriteLine("Küçük sayı girdiniz...");
            //    goto don;
            //}
            //else if (tahminisayi > sayi)
            //{
            //    Console.WriteLine("Büyük sayı girdiniz...");
            //    goto don;
            //}
            //else
            //{
            //    Console.WriteLine("tebrikler doğru bildiniz adım sayınız{0}: ",adim);
            //}

            //  Console.ReadLine();





            //ORNEK3


            //urun fiyatı 100 ile 250 arasında randam değer ata
            //kullanıcıdan kodları iste
            //eger kod1 ise ürün fiyatına %18 kdv uygula
            //eger kod2 ise ürün fiyatına %8 kdv uygula
            //eger kod3 ise ürün fiyatına %1 kdv uygula
            //eger kodlar yanlış ise isleme devam etmek ister misin yukarı git

            Random rastgele = new Random();
            int fiyat = rastgele.Next(100, 251);
            Console.WriteLine(" KDV'SİZ ÜRÜN FİYATI: " + fiyat);
            
            DON:
            Console.WriteLine("ÜRÜN KODU GİRİNİZ: ");
            Console.WriteLine("***KOD SEÇENEKLERİ***");
            Console.WriteLine("KOD1 İÇİN (1) Giriniz");
            Console.WriteLine("KOD2 İÇİN (2) Giriniz");
            Console.WriteLine("KOD3 İÇİN (3) Giriniz");
            char secim= Convert.ToChar(Console.ReadLine());

            if (secim == '1')
            {
                int kdv1 = fiyat + (fiyat * 18 / 100);
                Console.WriteLine("KDV'Lİ FİYAT: " + kdv1);
            }
            else if (secim == '2')
            {
                int kdv2 = fiyat + (fiyat * 8 / 100);
                Console.WriteLine("KDV'Lİ FİYAT: " + kdv2);
            }
            else if (secim == '3')
            {
                int kdv3 = fiyat + (fiyat * 1 / 100);
                Console.WriteLine("KDV'Lİ FİYAT: " + kdv3);
            }
            else
            {
                Console.WriteLine("YANLIŞ KOD GİRDİNİZ TEKRAR DENEYİNİZ..");
                goto DON;
            }

            Console.ReadLine();

























        }
    }
}
