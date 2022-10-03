using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    class dahiliye : hastane
    {

        public override int MuayaneUcret(int fiyat)
        {
            fiyat += fiyat * 8 / 100;
            return fiyat;
        }


        public override void Hemsire()
        {
            base.Hemsire();
        }

    }
}
