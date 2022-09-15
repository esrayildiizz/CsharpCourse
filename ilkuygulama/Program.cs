using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkuygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main bir metot'dur. 
            //her prograöda bir class olmalı
            //Tüm uygulamalar buradan çalışır.

            int a = 10;
            int b = 15;
            int toplam = 0;
            toplam = a + b;

            Console.WriteLine("Sayı1 değerim:"+a);
            Console.WriteLine("Sayı2  değerim:"+b);
            Console.WriteLine("İki sayının toplamı:"+toplam);

            Console.ReadLine();
            
        }
    }
}
