using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    class karayollari : ulasimaraclari
    {
        public double plakano;
        public string aractip;
        public double duraksayisi;

        public override double Sonuc(double biletadet, double biletfiyat)
        {
           double sonuc= biletadet* biletfiyat;
           Console.WriteLine("Ödeyeceğiniz tutar: "+sonuc);
           return sonuc;
        }

        public override double Hesapla(double yolcukapasitesi, double biletfiyat)
        {
            return base.Hesapla(yolcukapasitesi, biletfiyat);
        }

        public override double KdvHesapla(double biletfiyat, string guzergah)
        {
            return base.KdvHesapla(biletfiyat, guzergah);
        }

        public double İndirim(double duraksayisi,double biletfiyat)
        {
            if (duraksayisi < 5)
            {
                biletfiyat -= biletfiyat * 10 / 100;
                return biletfiyat;
            }
            else if(duraksayisi>5 && duraksayisi < 10)
            {
                biletfiyat -= biletfiyat * 8 / 100;
                return biletfiyat;
            }
            else
            {
                biletfiyat -= biletfiyat * 5 / 100;
                return biletfiyat;
            }
            
        }

        public void VeriAl2()
        {
            VeriAl();
            Console.WriteLine("Plaka no giriniz: ");
            plakano= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Araç tipini girin: ");
            aractip = Console.ReadLine();
            Console.WriteLine("Durak sayısını giriniz: ");
            duraksayisi= Convert.ToDouble(Console.ReadLine());

        }
        public void VeriYazdir2()
        {
            VeriYazdir();
            Console.WriteLine("Plaka no:" + plakano);
            Console.WriteLine("Araç tipi: " + aractip);
            Console.WriteLine("Durak sayısı: " + duraksayisi);

        }
    }
}
