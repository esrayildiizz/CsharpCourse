using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    class kardiyoloji : hastane
    {
        public override int MuayaneUcret(int fiyat)
        {
            fiyat += fiyat * 10/ 100;
            return fiyat;
        }

        public override void Hemsire()
        {
            Console.WriteLine("Bu bölümün baş hemşiri Mahmut Yazıcı'dır. ");
        }

        public override int Katki(string durum, int fiyat)
        {
            if(durum== "Emekli")
            {
                fiyat += fiyat * 10 / 100;
                return fiyat;
            }
            else
            {
                fiyat += fiyat * 20 / 100;
                return fiyat;
            }
        }
    }
}
