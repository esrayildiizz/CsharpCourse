using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım6
{
    class GarantiBankasi : Banka
    {
        public double kredipuani;
        public string hizmetalan;
        public double cekilenkredisayisi;
        public string kreditipi;


        public override double Method(double aylikgider, double aylikgelir)
        {
            double fark = aylikgelir - aylikgider;
            Console.WriteLine("CİRO: "+fark);

            Console.WriteLine("Aylık Kar Menusu");
            Console.WriteLine("a-3 AYLIK");
            Console.WriteLine("b-6 AYLIK");
            Console.WriteLine("c-12 AYLIK");
            string sec = Console.ReadLine();
            if (sec == "a")
            {
                double kar = fark *3;
                double faiz =kar+kar * 3 / 100;
                Console.WriteLine("3 aylık faiz farkı :" + faiz);
                return faiz;
               
            }
            else if (sec == "b")
            {
                double kar = fark * 6;
                double faiz = kar + kar * 3 / 100;
                Console.WriteLine("6 aylık faiz farkı :" + faiz);
                return faiz;
            }
            else
            {
                double kar = fark * 12;
                double faiz = kar + kar * 3 / 100;
                Console.WriteLine("12 aylık faiz farkı :" + faiz);
                return faiz;
            }

        }

        public override double Method2(string bankatip, double hesapsayisi, double bankacilikciro)
        {
            if (bankatip == "Kurumsal")
            {
                if (hesapsayisi > 100000)
                {
                    double vergi = hesapsayisi * 18 / 100;
                    bankacilikciro -= vergi;
                    return bankacilikciro;
                }
                else if (hesapsayisi < 100000)
                {
                    double vergi = hesapsayisi * 8 / 100;
                    bankacilikciro -= vergi;
                    return bankacilikciro;
                }
                else
                {
                    Console.WriteLine("Hesap sayısı belirlenen aralıkta değil.");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Banka tip kurumsal değildir.");
                return 0;
            }
        }


        public void Method4()
        {
            if (kredipuani > 100 && kredipuani < 200 && Aylikgelir > 100000)
            {
                Console.WriteLine("Hangi kredi tipini seçmek istersiniz?");
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1-Bireysel Kredi");
                Console.WriteLine("2-Konut Kredi");
                Console.WriteLine("3-Taşıt Kredi");
                int secim = Convert.ToInt32(Console.Read());
                if (secim == 1)  //Bireysel kredi
                {
                    Console.WriteLine("Ne kadar ana para çekmek istersiniz?");
                    double anapara = Convert.ToDouble(Console.Read());
                    if (anapara < 50000)
                    {
                        Console.WriteLine("Aylık ödeme seçeneği seçin lütfen: ");
                        Console.WriteLine("Seçenekler");
                        Console.WriteLine("a-12AY");
                        Console.WriteLine("b-24AY");
                        string aylikodeme = Console.ReadLine();
                        if (aylikodeme == "a")
                        {
                            anapara += anapara * 2.05 / 100;
                            double tutar = anapara / 12;
                            Console.WriteLine(" Aylık Ödenecek tutar: " + tutar);
                        }
                        else if (aylikodeme == "b")
                        {
                            anapara += anapara * 2.40 / 100;
                            double tutar = anapara / 24;
                            Console.WriteLine(" Aylık Ödenecek tutar: " + tutar);
                        }
                    }
                }
                else if (secim == 2) //Konut kredi
                {
                    Console.WriteLine("Ne kadar ana para çekmek istersiniz?");
                    double anapara = Convert.ToDouble(Console.Read());
                    Console.WriteLine("Alacağım ev kaç yıllık?");
                    double evyil = Convert.ToDouble(Console.ReadLine());
                    if (evyil < 5)
                    {
                        double sonuc = anapara * 0.99 / 120;
                        Console.WriteLine("Aylık Ödeyeceğiniz tutar: " + sonuc);
                    }
                    else
                    {
                        double sonuc = anapara * 2.5 / 120;
                        Console.WriteLine("Aylık Ödeyeceğiniz tutar: " + sonuc);
                    }

                }


            }
        }


        public void VeriAl2()
        {
            VeriAl();
            Console.WriteLine("Kredi puani giriniz: (100-200)Arasında olmalıdır. ");
            kredipuani = Convert.ToDouble(Console.Read());
            Console.WriteLine("Hizmet alanı girin: ");
            hizmetalan= Console.ReadLine();
            Console.WriteLine("Çekilen kredi sayısı girin: ");
            cekilenkredisayisi = Convert.ToDouble(Console.Read());
            Console.WriteLine("Kredi tipi giriniz: (Bireysel Kredi/Konut Kredi/Taşıt Kredi)");
            kreditipi= Console.ReadLine();
        }

        public void VeriYazdir2()
        {
            VeriYazdir();
            Console.WriteLine("Kredi puani: " + kredipuani);
            Console.WriteLine("Hizmet alanı: "+hizmetalan);
            Console.WriteLine("Çekilen kredi sayısı : "+cekilenkredisayisi);
            Console.WriteLine("Kredi tipi: "+kreditipi);

        }
    }
}
