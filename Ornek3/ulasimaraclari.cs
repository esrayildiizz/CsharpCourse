using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    abstract class ulasimaraclari
    {
        private double ulasimno;
        private double yolcukapasitesi;
        private string guzergah;
        private double biletfiyat;
        private double biletadet;

        public double Ulasimno
        {
            get
            {
                return ulasimno;
            }
            set
            {
                ulasimno = value;
            }
        }
        public double Yolcukapasitesi
        {
            get
            {
                return yolcukapasitesi;
            }
            set
            {
                yolcukapasitesi = value;
            }
        }
        public string Guzergah
        {
            get
            {
                return guzergah;
            }
            set
            {
                guzergah = value;
            }
        }
        public double Biletfiyat
        {
            get
            {
                return biletfiyat;
            }
            set
            {
                biletfiyat = value;
            }
        }
        public double Biletadet
        {
            get
            {
                return biletadet;
            }
            set
            {
                biletadet = value;
            }
        }

        public abstract double Sonuc(double biletadet, double biletfiyat); //ana class taki abstract method un gözdesi olmaz.
        

        public virtual double Hesapla(double yolcukapasitesi, double biletfiyat)  //Polymorphism method :BASE CLASS TA VİRTUAL OLARAK YAZILIR.
        {
            if(yolcukapasitesi>10 && yolcukapasitesi < 20)
            {
                biletfiyat += biletfiyat * 2 / 100;
                return biletfiyat;
            }
            else if(yolcukapasitesi>20 && yolcukapasitesi < 30)
            {
                biletfiyat += biletfiyat * 3 / 100;
                return biletfiyat;
            }
            else
            {
                biletfiyat += biletfiyat * 5 / 100;
                return biletfiyat;
            }
        }

        public virtual double KdvHesapla(double biletfiyat,string guzergah)
        {
            if (guzergah == "İstanbul")
            {
                biletfiyat+=biletfiyat*2.5 / 100;
                return biletfiyat;
            }
            else if (guzergah == "Ankara")
            {
                biletfiyat += biletfiyat * 3.5 / 100;
                return biletfiyat;
            }
            else if (guzergah == "İzmit")
            {
                biletfiyat += biletfiyat * 5.5 / 100;
                return biletfiyat;
            }
            else
            {
                biletfiyat += biletfiyat * 6.5 / 100;
                return biletfiyat;
            }
        }
        public void VeriAl()
        {
            Console.WriteLine("Ulaşım no giriniz:");
            Ulasimno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yolcu kapasitesini giriniz: ");
            Yolcukapasitesi= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Güzergah giriniz: ");
            Guzergah = Console.ReadLine();
            Console.WriteLine("Bilet fiyatını yazını: ");
            Biletfiyat= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bilet adetini giriniz: ");
            Biletadet= Convert.ToDouble(Console.ReadLine());
        }
        public void VeriYazdir()
        {
            Console.WriteLine("Ulaşım no: " + Ulasimno);
            Console.WriteLine("Yolcu kapasitesi: " + Yolcukapasitesi);
            Console.WriteLine("Güzergah: " + Guzergah);
            Console.WriteLine("Bilet fiyatı: "+Biletfiyat);
            Console.WriteLine("Bilet adeti:" +Biletadet);
        }
    }
}
