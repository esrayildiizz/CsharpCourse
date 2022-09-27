using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class mng
    {
        private string kargotipi;
        private string sehir;
        private double mesafefiyat;
        private double km;

        public string Kargotipi
        {
            get
            {
                return kargotipi;
            }
            set
            {
                if (value=="metal" || value=="plastik")
                {
                    kargotipi = value;
                }
                else
                {
                    Console.WriteLine("Kırılma tehlikesi vardır.Sorumluluk kabul etmiyoruz...");
                }
            }
        }

        public string Sehir
        {
            get
            {
                return sehir;
            }
            set
            {
               sehir = value;

            }
        }


        public double Mesafefiyat
        {
            get
            {
                return mesafefiyat;
            }
            set
            {
                mesafefiyat = value;

            }
        }

        public double Km
        {
            get
            {
                return km;
            }
            set
            {
                km = value;

            }
        }

        public double Hesapla(double km, double mesafefiyat)
        {
            if (kargotipi == "plastik")
            {
                double ucret = km * mesafefiyat;
                return ucret;
            }
            else if(kargotipi == "metal")
            {
                double ucret = (km * mesafefiyat) * 20 / 100;
                return ucret;
            }
            else
            {
                double ucret = (km * mesafefiyat) * 50 / 100;
                return ucret;
            }
        }


        public void VeriAl()
        {
            Console.WriteLine("Kargo Tipini girin:");
            Kargotipi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Km girin:");
            Km = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Mesafe fiyat girin: ");
            Mesafefiyat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Şehir girin: ");
            Sehir = Convert.ToString(Console.ReadLine());
        }

        public void EkranaYazdir()
        {
            VeriAl();
            Console.WriteLine("Kargo TipiniZ: " + Kargotipi);
            Console.WriteLine("KM: " + Km);
            Console.WriteLine("Mesafe: " + Mesafefiyat);
            Console.WriteLine("Şehir: " + Sehir);

            Console.WriteLine("Ödemeniz gereken ücret : " + Hesapla(Km,Mesafefiyat));

        }




    }
}
