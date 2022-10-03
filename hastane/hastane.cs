using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    abstract class hastane //hastane soyutlanmıs artık nesne üretmez kalıtım bırakarak yavru classın 
    {

        private int hastano;
        private string hastaneadi;
        private string hastaad;
        private int fiyat;
        public string durum;

        public int Hastaneno
        {
            get
            {
                return hastano;
            }
            set
            {
                hastano = value;
            }
        }

        public string Hastaneadi
        {
            get
            {
                return hastaneadi;
            }
            set
            {
                hastaneadi = value;
            }
        }

        public string Hastaad
        {
            get
            {
                return hastaad;
            }
            set
            {
                hastaad = value;
            }
        }

        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
               fiyat = value;
            }
        }



        public abstract int MuayaneUcret(int fiyat);


        public virtual void Hemsire()
        {
            Console.WriteLine("Hastanemizin baş hemşiresi Canan Genç'tir.");
        }

        public virtual int Katki(string durum,int fiyat)
        {
            if (durum == "Emekli")
            {
                fiyat += fiyat * 1 / 100;
                return fiyat;
            }
            else
            {
                fiyat += fiyat * 10 / 100;
                return fiyat;
            }
        }
    }
}
