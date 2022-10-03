using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEÇENEKLER");
            Console.WriteLine("1-Karayolları");
            Console.WriteLine("2-Denizyolları");
            Console.WriteLine("3-Havayolları");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Karayolları seçtiniz....");
                    karayollari arac1 = new karayollari();
                    arac1.VeriAl2();
                    double islem1 = arac1.Sonuc(arac1.Biletadet,arac1.Biletfiyat);
                    double kdv = arac1.KdvHesapla(islem1, arac1.Guzergah);
                    arac1.İndirim(arac1.duraksayisi, kdv);
                    arac1.VeriYazdir2();
                    Console.WriteLine();
                    Console.WriteLine("Kdvli ödeme tutarınız:"+kdv);
                    break;
                case 2:
                    Console.WriteLine("Denizyollarını seçtiniz....");
                   
                break;
                case 3:
                    Console.WriteLine("Havayollarını seçtiniz....");
                    havayollari arac3 = new havayollari();
                    arac3.VeriAl3();
                    double islem2 = arac3.Sonuc(arac3.Biletadet, arac3.Biletfiyat);
                    double kdv3 = arac3.KdvHesapla(islem2, arac3.Guzergah);
                    arac3.VeriYazdir3();
                    Console.WriteLine();
                    Console.WriteLine("Kdvli ödeme tutarınız:" + kdv3);

                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                break;
            }

            Console.ReadLine();
        }
    }
}
