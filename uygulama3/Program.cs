using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

             int toplam = sayi + sayi2;

            Console.WriteLine("Sayıların Toplamı : " + toplam);
            Console.ReadLine();
        }
    }
}
