using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım3
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Console.WriteLine("1-Akıllı Telefon");
            Console.WriteLine("2-Tuşlu Telefon");

            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Akıllı Telefon ekranı");
                AkilliTelelefonlar tel1 = new AkilliTelelefonlar();
                tel1.VeriSat();
                tel1.EkranaAt();
            }
            else
            {
                Console.WriteLine("Tuşlu Telefon ekranı");
                TusluTelefonlar tel2 = new TusluTelefonlar();
                tel2.verial3();

            }


            Console.ReadLine();
          

        }
    }
}
