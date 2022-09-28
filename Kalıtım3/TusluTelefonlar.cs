using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım3
{
    class TusluTelefonlar:Telefonlar    
    {
        public int ekraninc;
        public bool bluetooth;

        public void verial3()
        {
            VerilAl(); //telefon dan alındı.
            Console.WriteLine("Ekran inç gir: ");
            ekraninc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bluetooth var mı ?");
            bluetooth = Convert.ToBoolean(Console.ReadLine());

            if(ekraninc>5  && ekraninc < 10)
            {
                sonfiyat -= sonfiyat * 20 / 100;
                Console.WriteLine("Ödemeniz gereken tutar: "+sonfiyat);
            }
            else
            {
                sonfiyat -= sonfiyat * 50 / 100;
                Console.WriteLine("Ödemeniz gereken tutar: " + sonfiyat);
            }

        }
    }
}
