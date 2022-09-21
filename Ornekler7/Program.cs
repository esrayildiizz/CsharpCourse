using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler


            //ornek1
            //int[] sayilar = { 4, 1, 7, 23, 14, 51};
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine("dizi elemanları: "+i);
            //}

            //Console.Read();






            //ornek2

            //int[] sayilar = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1+". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 0; i < 5; i++) //dizi içindeki verileri yazdırıyoruz.
            //{
            //    Console.WriteLine(i + 1 + ". İsim: "+ sayilar[i]);
            //}
            //Console.ReadLine();








            //ornek3

            //string [] isimler = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1+". İsmi Girin: ");
            //    isimler[i] = Convert.ToString(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 4; i>=0; i--)
            //{
            //    Console.WriteLine("****Sıralama****");
            //    Console.WriteLine(i+1+" . isimler: " + isimler[i]);
            //}

            //Console.ReadLine();






            //ornek4
            //6 elemanlı dizinin elemanlarının toplamını ve ortalamasını bulan prog.

            //int[] sayilar = new int[6];
            //float toplam = 0;
            //float ort = 1;

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(i + 1 + ". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
              
            //}
            //Console.Clear();
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(i + 1 + " . sayı: " + sayilar[i]);
            //    toplam = toplam + sayilar[i];
            //    ort = toplam / 6;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Sayıların toplam: "+toplam);
            //Console.WriteLine("Sayıların ortaması: " + ort);
            //Console.ReadLine();





            //ornek5
            //diziye dışarıdan girilen 10 sayının 5 ve 7 ye bölünenlerin adedi bölünmeyenlerin ise ort veren program

            int[] sayilar = new int[10];
            int adet5 = 0;
            int adet7 = 0;
            float toplam = 0;
            float ort = 1;

            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine(i + 1 + ". Sayıyı Girin: ");
               sayilar[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " . sayı: " + sayilar[i]);
                if (sayilar[i] % 5 == 0)
                {
                    adet5++;
                }
                else if (sayilar[i] % 7 == 0)
                {
                    adet7++;
                }
                toplam = toplam + sayilar[i];
                ort = toplam / 10;
            }
            Console.WriteLine("5'e bölünen sayılar: "+adet5);
            Console.WriteLine("7'e bölünen sayılar: "+adet7);
            Console.WriteLine("Sayıların ortaması: " + ort);
            Console.ReadLine();











        }
    }
}
