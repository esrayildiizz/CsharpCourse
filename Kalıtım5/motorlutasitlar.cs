using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım5
{
    abstract class motorlutasitlar //base class  //soyut class yaptık ve bu classtan nesne üretemeyiz.
    {
        int hacim;
        int tekersayisi;
        int beygir;
        string marka;
        string model;
        int silindir;
        string ehliyet;
        string renk;


        public int Hacim
        {
            get { return hacim; }
            set { hacim = value; }
        }


        public int Tekersayısı
        {
            get { return tekersayisi; }
            set { tekersayisi = value; }
        }

        public int Beygir
        {
            get { return beygir; }
            set { beygir = value; }
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Silindir
        {
            get { return silindir; }
            set { silindir = value; }
        }

        public string Ehliyet
        {
            get { return ehliyet; }
            set { ehliyet = value; }
        }

        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }

        public int Ozellik(string marka, string model, int fiyat)
        {
            if (marka == "hyundai" && model == "i20")
            {
                fiyat -= fiyat * 10 / 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }

        // abstrackt method.. abstrackt olan classda sadece gövdesi tanımlanır..
        public abstract void Metot(string a, string b);
        public abstract int metot2(int fiyat);


    }
}
