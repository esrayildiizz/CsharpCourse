using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Urunler
    {
        private string urunno;
        private string marka;
        private string model;
        private int fiyat;
        private string cekdurumu;
        private double kdvorani;


        public string UrunNo
        {
            get
            { 
                return urunno;
            }
            set 
            {
                urunno = value; 
            }
        }

        public string Marka
        {
            get 
            {
                return marka; 
            }
            set 
            { 
                if(value=="vestel" || value == "beko")
                {
                    marka = value;
                }
                else
                {
                    Console.WriteLine("Başka firmalarla çalışmıyooruz....");
                }
            }
        }

        public string Model
        {

            get
            {
                return model;
            }
            set
            {
                model = value;
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
                if (value>10000 && value<20000 )
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Fiyat aralığımıza uygun değil...");
                }
            }

        }

        public string CekDurumu
        {
            get
            {
                return cekdurumu;
            }
            set
            {
                cekdurumu = value;
            }
        }

        public double KdvOrani
        {
            get
            {
                return kdvorani;
            }
            set
            {
                if (value >1 && value < 18)
                {
                   kdvorani = value;
                }
                else
                {
                    Console.WriteLine("Yüzde aralığımıza uygun değil...");
                }
            }
        }


        public double Tutar(double fiyat,double kdvorani)
        {
            fiyat += fiyat * kdvorani / 100;
            return fiyat;
        }


    }
}
