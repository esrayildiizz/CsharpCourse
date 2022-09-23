using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler8
{
    class Program
    {
        //Metotlar



        //public static void Topla()
        //{
        //    Console.WriteLine("1.Sayıyı giriniz: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayıyı giriniz: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());
        //    int toplam = sayi + sayi2;
        //    Console.WriteLine("Toplam Sonucu: "+toplam);
        //}




        //public static void DAlanHesapla(int kısakenar,int uzunkenar)
        //{
        //    int alan = kısakenar * uzunkenar;
        //    Console.WriteLine("Alan sonuç: "+alan);
        //}




        //public static void KareAlan(int kenar)
        //{
        //    int karealan = kenar * kenar;
        //    Console.WriteLine("Karenin Alanı: "+karealan);
        //}




        //public static void EnBüyük(int a,int b)// // parametreli girdiğimiz için metodun dışında o parametreleri çağırmamız yani istememiz gerekir.
        //{
        //int enbüyük = -999999;
        //if (a > enbüyük)
        //    enbüyük = a;
        //else if (b < enbüyük)
        //    enbüyük = b;
        //Console.WriteLine("EN BÜYÜK SAYI:  " + enbüyük);
        //}




        // public static void BölenBulma(int x) 
        // {
        //    int adet = 0;
        //    for (int i = 0; i < x; i++)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            adet++;
        //        }
        //    }
        //    Console.WriteLine("5e Bölünen sayıların adedi: " + adet);
        //}




        //public static int FiyatHesapla(int fiyat)
        //{
        //    if (fiyat > 100)
        //    {
        //        fiyat += fiyat * 20 / 100;
        //        return fiyat;
        //    }
        //    else
        //    {
        //        fiyat += fiyat * 10 / 100;
        //        return fiyat;
        //    }

        //}





        //iki parametreli geriye değer dondüren metot
        //birim fiyat versin  doların tutarına göre.
        //public static int DolarHesapla(int a,int b) //a:birim fiyat  //b:dolar
        //{
        //    int tutar= a * b;
        //    return tutar;
        //}


        static void Main(string[] args)
        {
            //Topla();
            //Console.ReadLine();


            //Console.WriteLine("dİKDÖRTGEN Alan Hesaplama");
            //Console.WriteLine("Kısa Kenarı Giriniz: ");
            //int kenar1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uzun Kenarı Giriniz: ");
            //int kenar2 = Convert.ToInt32(Console.ReadLine());
            //DAlanHesapla(kenar1,kenar2);


            //Console.WriteLine("En büyük sayıyı bulma");
            //Console.WriteLine("1.Sayıyı giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //EnBüyük(a, b);


            //Console.WriteLine("****5e Bölünenler Sayıları Bulma****");
            //Console.WriteLine("Sayı giriniz: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //BölenBulma(x);



            //Console.WriteLine("***Fiyat Hesaplama Ekranı***");
            //Console.WriteLine("Fiyat giriniz: ");
            //int fiyat= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(FiyatHesapla(fiyat));




            //Console.WriteLine("***Dolar Hesaplama Ekranı***");
            //Console.WriteLine(" Dolar Fiyatı giriniz: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Kaç TL Fiyatını Öğrenmek istersiniz?: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dolar Tutarı: "+DolarHesapla(a,b));


            Console.ReadLine();
        }
    }
}
