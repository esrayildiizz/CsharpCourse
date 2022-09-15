using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Ürün Sayfası****");

            Console.WriteLine("Ürün Adını Giriniz: ");
            string urunad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ürün fiyatını girin: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ürün indirimi giriniz: ");
            double indirim =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ürün kargo ücretini giriniz: ");
            double kargofiyat = Convert.ToDouble(Console.ReadLine());

            double fatura = (fiyat - indirim) + kargofiyat;

            Console.WriteLine();
            Console.WriteLine("****Fatura Ekranı****");
            Console.WriteLine("Ürün adı: " + urunad);
            Console.WriteLine("Ürün fiyatı: " + fiyat);
            Console.WriteLine("Ürün için ödemeniz gereken indirimli tutar: " + fatura);
            Console.ReadLine();

        }
    }
}
