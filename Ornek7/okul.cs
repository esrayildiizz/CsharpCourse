using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek7
{
    class okul
    {
        
        public struct Kolej1
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
    }
}
