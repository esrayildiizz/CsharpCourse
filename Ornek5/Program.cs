using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    class Program
    {
        enum Sonuc
        {
            pekiyi=100,
            iyi=75,
            orta=50,
            zayif=25,

        }
        static void notaciklama(Sonuc notlar)
        {
            if (notlar == Sonuc.pekiyi)
            {
                Console.WriteLine("Başarılar");
            }
            if (notlar == Sonuc.iyi)
            {
                Console.WriteLine("Daha iyisi olabilir.");
            }
            if (notlar == Sonuc.orta)
            {
                Console.WriteLine("Neden daha iyi olmasın.");
            }
            if (notlar == Sonuc.zayif)
            {
                Console.WriteLine("Çok çalışman gerekiyor.");
            }
        }

        static void Main(string[] args)
        {
            Sonuc yeni = Sonuc.pekiyi;
            Console.WriteLine("En iyi not: "+yeni.ToString());
            Sonuc yeni1 = Sonuc.zayif;
            Console.WriteLine("En kötü not: "+yeni1.ToString());

            Console.ReadLine();
        }


    }
}
