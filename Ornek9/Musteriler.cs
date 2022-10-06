using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    //iç içe classlar (nested class-gömülü class)
    public class Musteriler  //outer class ın erişim belirleyicisi internal
    {
        public int musterino;
        public string musteriadsoyad;

        public void Bilgi()
        {
            Console.WriteLine("Standart Müşteri");
        }

        public class VipMusteriler: Musteriler //inner class ın erişim belirleyicisi private
        {
            public int bakiye;
            public string uye;

            public void Durum()
            {
                Console.WriteLine("Zengin Müşteri");
            }
        }
    }
}
