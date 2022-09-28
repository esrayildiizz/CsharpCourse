using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class yurtici
    {
        private int agirlik;
        private double birimfiyat;
        private string bolge;
        private double vergiorani;
        double mesafeucret;

        public int Agirlik
        {
            get
            {
                return agirlik;
            }
            set
            {
                if (value < 30 )
                {
                    agirlik= value;
                }
                else
                {
                    Console.WriteLine("Ağırlık 30'dan fazla olamaz.");
                }
            }

        }
        public double BirimFiyat
        {
            get
            {
                return birimfiyat;
            }
            set
            {
                if (value > 20 && value<100)
                {
                    birimfiyat = value;
                }
                else
                {
                    Console.WriteLine("Birimfiyat aralığı 20 ile 100 arasında olmalı.");
                }
            }
        }
        public string Bolge
        {
            get
            {
                return bolge;
            }
            set
            {
                 bolge = value;
                
            }
        }
        public double Yurtdisi(double birimfiyat,double mesafeucret ,string bolge)
        {
           
            if(bolge=="yurtdışı")
            {
                Console.WriteLine("yurt dışı hesaplaması yapılcak bilginize...");
                double sfiyat = Ucret(birimfiyat, vergiorani);
                sfiyat *= mesafeucret;
                return sfiyat;
            }
            else
            {
                return birimfiyat;
            }
           
        }

        public double VergiOrani
        {
            get
            {
                return vergiorani;
            }
            set
            {
                if (value <=5)
                {
                    vergiorani = value;
                }
                else
                {
                    Console.WriteLine("Vergi oranı en fazla 5 olabilir..");
                }
            }
        }

        public  double Ucret(double birimfiyat, double vergiorani)
        {
            if (birimfiyat < 50)
            {
                birimfiyat -= (birimfiyat + vergiorani) * 2.5f / 100; 
                return birimfiyat;
            }
            else
            {
                birimfiyat -= (birimfiyat + vergiorani) * 1.5f / 100; 
                return birimfiyat;
            }
            
        }


        public void VeriAl()
        {
            Console.WriteLine("Kargo Ağırlığını girin:");
            Agirlik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birim fiyatı girin:");
            BirimFiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölgeyi girin (yurtiçi /yurtdışı): ");
            Bolge = Console.ReadLine();
            Console.WriteLine("Vergi oranını girin: ");
            VergiOrani = Convert.ToInt32(Console.ReadLine());
        }

        public void EkranaYazdir()
        {
            VeriAl();
            Console.WriteLine("Ağırlık : "+ Agirlik);
            Console.WriteLine("Birim fiyat: "+BirimFiyat);
            Console.WriteLine("Bölge: "+Bolge);
            Console.WriteLine("Vergi Oranı: "+VergiOrani);

            Console.WriteLine("ücret : " + Yurtdisi(BirimFiyat, VergiOrani,Bolge));

        }

    }
}
