using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler.VipMusteriler musteri1 = new Musteriler.VipMusteriler();
            musteri1.bakiye = 8000;
            musteri1.uye = "evet";
            musteri1.musteriadsoyad = "ali";
            musteri1.Durum();

            Musteriler musteri2 = new Musteriler();
            musteri2.musteriadsoyad = "Ali";
            musteri2.musterino = 12;

            musteri2.Bilgi();


            KralMusteri musteri3 = new KralMusteri();
            musteri3.musteriadsoyad = "veli";
            musteri3.musterino = 45;

        }
    }
}
