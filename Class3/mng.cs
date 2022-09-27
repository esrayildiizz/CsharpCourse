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
        private string ulasimtürü;
        private double teslimatsaat;
        private double gun;

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

        public string Ulasimtürü
        {
            get
            {
                return ulasimtürü;
            }
            set
            {
                ulasimtürü = value;
                
            }
        }

        public double Teslimatsaat
        {
            get
            {
                return teslimatsaat;
            }
            set
            {
                teslimatsaat = value;

            }
        }
        public double Gun
        {
            get
            {
                return gun;
            }
            set
            {
                gun= value;

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

        public double Teslimat(string ulasimtürü,double teslimatsaat,double gun)
        {
            if (ulasimtürü =="hızlı teslimat")
            {
                Console.WriteLine("Teslimat saatini giriniz:");
                teslimatsaat= Convert.ToDouble(Console.ReadLine());

                if (teslimatsaat < 2)
                {
                    double son = Hesapla(Km, Mesafefiyat) + 50;
                    return son;
                }
                else if(teslimatsaat>2 && teslimatsaat < 5)
                {
                    double son = Hesapla(Km, Mesafefiyat) + 30;
                    return son;
                }
                else if(teslimatsaat<5 && teslimatsaat < 100)
                {
                    double son = Hesapla(Km, Mesafefiyat) + 20;
                    return son;
                }
                else
                {
                    double son = Hesapla(Km, Mesafefiyat);
                    return son;
                }
            }
            else if (ulasimtürü == "günlük teslimat")
            {
                Console.WriteLine("Kaç gün içerisinde teslim edilsin?");
                gun= Convert.ToDouble(Console.ReadLine());

                if (gun == 1)
                {
                    double son = Hesapla(Km, Mesafefiyat) + 7.5d;
                    return son;
                }
                else if (gun == 2)
                {
                    double son = Hesapla(Km, Mesafefiyat) + 4.5d;
                    return son;
                }
                else
                {
                    double son = Hesapla(Km, Mesafefiyat);
                    return son;
                }
            }
            else
            {
                double son = Hesapla(Km, Mesafefiyat);
                return son;
            }
           
        }

        public void VeriAl()
        {
            Console.WriteLine("Kargo Tipini girin:(metal/plastik/cam)");
            Kargotipi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Km girin:");
            Km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mesafe fiyat girin: ");
            Mesafefiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Şehir girin: ");
            Sehir = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ulaşım türü giriniz:(hızlı teslimat/günlük teslimat)");
            Ulasimtürü= Convert.ToString(Console.ReadLine());
         
        }

        public void EkranaYazdir()
        {
            VeriAl();
            Console.WriteLine("***Kargo Bilgileri****");
            Console.WriteLine("Kargo TipiniZ: " + Kargotipi);
            Console.WriteLine("KM: " + Km);
            Console.WriteLine("Mesafe: " + Mesafefiyat);
            Console.WriteLine("Şehir: " + Sehir);
            Console.WriteLine("Ulaşım Türünüz: "+Ulasimtürü);
            Console.WriteLine("**********************");
            Console.WriteLine("Ödemeniz gereken ücret : " + Teslimat(Ulasimtürü,Teslimatsaat,Gun));

        }


    }
}
