using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler4
{
    class Program
    {
        static void Main(string[] args)
        {


            //Yıldızlarla şekil çizme
            //ornek1

            //Console.WriteLine("BİR SAYI GİRİN: ");
            //int sayi= Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <=sayi; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();








            //ornek2

            //klavyeden okunan metni tersten yazma

            //Console.Write("Bir metin giriniz: ");
            //string metin = Console.ReadLine();

            //metni ters yazdırma
            //for (int i = metin.Length-1 ; i >= 0; i--)
            //{
            //    Console.Write(metin[i]);
            //}



            //düzden alt alta yazdırma
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    Console.WriteLine(metin[i]);
            //}

            // metnin arasına (-) koysun
            //for (int i = 0; i < metin.Length; i++)
            //{

            //    if ((metin.Length-1) ==i)
            //    {
            //        Console.Write(metin[i]);

            //    }
            //    else
            //    {
            //        Console.Write(metin[i]+"-");
            //    }
            //}


            //Console.ReadLine();









            //ornek3


            //Console.WriteLine("BİR CÜMLE GİRİN: ");
            //string cümle = Convert.ToString(Console.ReadLine());

            //for (int i = 0; i <= cümle.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(cümle[j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();







            //ornek4


            //random istenilen sayı kadar harf yazan program
            //string harf = "abcdefghijklmnoprstuvyz";
            //string uret = " ";
            //int sayi;
            //Random rastgele = new Random();

            //Console.Write("kaç harfli olmasını istersiniz :");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    uret += harf[rastgele.Next(harf.Length)];
            //}
            //Console.Write("Üretilen harfler :" + uret);
            //Console.ReadLine();









            //ornek5

            string sayi = "12345678910";

            for (int i = 0; i <= sayi.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sayi[j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();












        }
    }
}
