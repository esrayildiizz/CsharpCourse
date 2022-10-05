using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
      static class calisanlar
      {
        //bir class static ise içindekiler static olmalıdır.
        //bir alanı static tanımladıysak ondan nesne üretemeyiz.
        //bir alana otomatik olarak ulaşmak istiyorsam orayı static olarak tanımlarım.

        public static int calisanno;
        public static string calisanadi;
        public static int maas;
        public static string adres;


        public static void Hesapla()
        {
            Console.WriteLine("Paraları getir....");
        }
        public static void Getir()
        {
            Console.WriteLine("Maaşlar ayın 10 undan sonra yatıcak inş....");
        }
      }
}
