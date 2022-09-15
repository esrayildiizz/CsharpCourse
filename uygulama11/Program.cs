using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("***Kıdem Tazminatı Hesaplama****");
            basdon:
            Console.WriteLine("Yaşınızı Giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas > 18)
            {
                don:
                Console.WriteLine("Prim Yılınızı Giriniz:");
                float primyil = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Prim Gün Sayınızı Giriniz:");
                float primgün = Convert.ToSingle(Console.ReadLine());
               
               

                if (primyil==25 && primgün > 7200)
                {
                    Console.WriteLine("Maaşınızı Giriniz:");
                    float maas = Convert.ToSingle(Console.ReadLine());
                    float kidemtazminati = maas * primyil;
                    Console.WriteLine("Kıdem Tazminatınız: "+ kidemtazminati );

                    
                }
                else
                {
                    Console.WriteLine("Prim Yıl ve Prim Gününüz Hesaplamak İçin Uygun Değildir...");
                    goto don;
                }
            }
            else
            {
                Console.WriteLine("Yaşınız Hesaplamak İçin Uygun Değildir...");
                goto basdon;
            }

            Console.ReadLine();
        }
    }
}
