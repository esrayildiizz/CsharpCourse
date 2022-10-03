using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    class denizyollari
    {
         private string tasittip;
         private string kaptanadi;
         private int sefersaati;

        public denizyollari(string tasittip,string kaptanadi,int sefersaati) //yapıcı metodumuz.
        {
            this.tasittip = tasittip;
            this.kaptanadi = kaptanadi;
            this.sefersaati = sefersaati;
        }

        public string Tasittip
        {
            get
            {
                return tasittip;
            }
            set
            {
                if (value == "Motorlu")
                {
                    tasittip = value;
                }
                else
                {
                    Console.WriteLine("Girilen değer olmadı...");
                }
            }
        }

        public string Kaptanadi
        {
            get
            {
                return kaptanadi;
            }
            set
            {
                if (value == "Osman")
                {
                    kaptanadi = value;
                }
                else
                {
                    Console.WriteLine("Girilen değer olmadı...");
                }
            }
        }
        public int Sefersaati
        {
            get
            {
                return sefersaati;
            }
            set
            {
                if (value == 15)
                {
                    sefersaati = value;
                }
                else
                {
                    Console.WriteLine("Girilen değer olmadı...");
                }
            }
        }


    }
}
