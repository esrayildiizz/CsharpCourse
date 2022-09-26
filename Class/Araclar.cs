using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Araclar
    {
        public string marka;
        public string model;
        public double fiyat;
        public double vergiorani;

        public double OTV(double fiyat,double vergiorani)
        {
            fiyat = fiyat * vergiorani / 1000;

            fiyat *= 2;
            return fiyat;
        }
    }
}
