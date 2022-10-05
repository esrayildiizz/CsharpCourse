using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek7
{
    class Program
    {

        struct Kolej
        {
            public int kolejno;
            private string okuladi;

            public string Okuladi
            {
                get
                {
                    return okuladi;
                }
                set
                {
                    okuladi = value;
                }
            }

            public void VeliBilgilendirme()
            {
                Console.WriteLine("Haftasonu hilton otelde seminer var gelmenizi rica ederiz. ");
            }
        } 

        static void Main(string[] args)
        {
            Kolej aa = new Kolej();
            aa.kolejno = 14;
            aa.Okuladi = "ATATÜRK OKULU";
            aa.VeliBilgilendirme();

            okul okul1 = new okul();
            okul.Kolej1 gg = new okul.Kolej1();

            Console.ReadLine();
        }
    }
}
