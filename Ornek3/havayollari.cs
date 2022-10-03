using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    sealed class havayollari : ulasimaraclari
    {
        public override double Sonuc(double biletadet, double biletfiyat)
        {
            double sonuc = biletadet * biletfiyat;
            Console.WriteLine("Ödeyeceğiniz tutar: "+sonuc);
            return sonuc;
        }

        public override double KdvHesapla(double biletfiyat, string guzergah)
        {
            return base.KdvHesapla(biletfiyat, guzergah);
        }

        public double Hatlar(double biletfiyat)
        {
            Console.WriteLine("Hat bilgisi giriniz: (hat dışı /hat içi)");
            string sec = Console.ReadLine();
            if(sec=="Hat içi" || sec=="Hat İçi")
            {
                biletfiyat += biletfiyat * 20 / 100;
                return biletfiyat;
            }
            else
            {
                Console.WriteLine("Rezervasyonunuz varmı?");
                string cevap = Console.ReadLine();
                if(cevap=="Evet" || cevap == "evet")
                {
                    biletfiyat += biletfiyat * 30 / 100;
                    return biletfiyat;
                }
                else
                {
                    return biletfiyat;
                }
            }
        }

        public void VeriAl3()
        {
            VeriAl();
        }
        public void VeriYazdir3()
        {
            VeriYazdir();
        }
    }
}
