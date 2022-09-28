//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kalıtım2
//{
//    class Emlak
//    {
//        private string yapidurum;
//        private string belgead;
//        private string belgeno;
//        private string emlakcins;
//        private string belgesorumlusu;
//        private string alimsatimsorumlusu;
//        private string alimdurum;
//        private double komisyon;
//        private double fiyat;

//        public string Yapidurum
//        {
//            get
//            {
//                return yapidurum;
//            }
//            set
//            {
//                if (value == "Bağ" || value == "Arazi" || value == "Tarla")
//                    yapidurum = value;
//                else
//                {
//                    value = "-";
//                }
//            }
//        }
//        public string Belgead
//        {
//            get
//            {
//                return belgead;
//            }
//            set
//            {
//                belgead = value;
//            }
//        }
//        public string Belgeno
//        {
//            get
//            {
//                return belgeno;
//            }
//            set
//            {
//                if (value.Length == 4)
//                    belgeno = value;
//                else
//                {
//                    value = "-";
//                    Console.WriteLine("Belgo no 4 karakterli olmalıdır...");
//                }
//            }
//        }
//        public string Emlakcins
//        {
//            get
//            {
//                return emlakcins;
//            }
//            set
//            {
//               emlakcins= value;
//            }
//        }
//        public string Belgesorumlusu
//        {
//            get
//            {
//                return belgesorumlusu;
//            }
//            set
//            {
//                belgesorumlusu = value;
//            }
//        }

//        public string Alimsatimsorumlusu
//        {
//            get
//            {
//                return alimsatimsorumlusu;
//            }
//            set
//            {
//               alimsatimsorumlusu = value;
//            }
//        }
//        public string Alimdurum
//        {
//            get
//            {
//                return alimdurum;
//            }
//            set
//            {
//                alimdurum = value;
//            }
//        }

//        public double Komisyon
//        {
//            get
//            {
//                return komisyon;
//            }
//            set
//            {
//                komisyon = value;
//            }
//        }
//        public double Fiyat
//        {
//            get
//            {
//                return fiyat;
//            }
//            set
//            {
//                fiyat = value;
//            }
//        }
//        public void Method() //alımdurum metodu
//        {
//            double depozito = 1000;
//            double vergidilimi = 50;
//            if (alimdurum == "Kiralık" || alimdurum == "kiralık")
//            {
//                Console.WriteLine("Kaç yıllık sözleşme yapılsın?");
//                double sozlesme = Convert.ToInt32(Console.Read());

//                if (sozlesme == 1)
//                {
//                    double sonuc = fiyat + komisyon + 2 * (depozito);
//                    Console.WriteLine("Ödeme tutarınız: " + sonuc);
//                }
//                else if (sozlesme > 1)
//                {
//                    double sonuc1 = fiyat + komisyon + (sozlesme) + 2 * (depozito);
//                    Console.WriteLine("Ödeme tutarınız: " + sonuc1);
//                }
//                else
//                {
//                    double sonuc1 = fiyat + komisyon + (sozlesme) + 2 * (depozito);
//                }
//            }
//            else if (alimdurum == "Satılık" || alimdurum == "satılık")
//            {
//                double sonucc = fiyat + komisyon + vergidilimi;
//                Console.WriteLine("Ödeme tutarınız: " + sonucc);
//            }
//            else
//            {
//                double sonucc = fiyat + komisyon + vergidilimi;
//            }
//        }

//        public void Method2() //emlakcins metodu
//        {

//            double yillikbedel = 500;
//            Console.WriteLine("Sözleşme yılı giriniz");
//            double sozlesmeyil = Convert.ToDouble(Console.ReadLine());

//            if ((emlakcins == "Kurumsal Emlak" || emlakcins == "KURUMSAL EMLAK") && (alimdurum == "KİRALIK" || alimdurum == "kiralık"))
//            {
//                double sonucc = (fiyat * 3 / 100) + komisyon + yillikbedel * sozlesmeyil;
//            }
//            else if (emlakcins != "Kurumsal Emlak" && (alimdurum == "KİRALIK" || alimdurum == "kiralık"))
//            {
//                double sonucc = fiyat * 1 / 100 + komisyon + yillikbedel * sozlesmeyil;
//            }
//        }


//        public void VeriAl()
//        {
//            Console.WriteLine("*****EMLAK BİLGİLERİ*****");
//            Console.WriteLine("Yapı durumunu giriniz: (Bağ/Arazi/Tarla)");
//            Yapidurum = Convert.ToString(Console.ReadLine());
//            Console.WriteLine("Belge ad girin:");
//            Belgead = Convert.ToString(Console.ReadLine());
//            Console.WriteLine("Belge no giriniz: ");
//            Belgeno = Console.ReadLine();
//            Console.WriteLine("Emlak cinsi giriniz: (Kurumsal Emlak /Kurumsal Olmayan Emlak) ");
//            Emlakcins = Console.ReadLine();
//            Console.WriteLine("Belge sorumlusunu giriniz: ");
//            Belgesorumlusu = Console.ReadLine();
//            Console.WriteLine("Alım-Satım sorumlusunu giriniz: ");
//            Alimsatimsorumlusu = Console.ReadLine();
//            Console.WriteLine("Alım durumunu giriniz: (Kiralık/Satılık)");
//            Alimdurum = Console.ReadLine();
//            Console.WriteLine("****************************");
//            Console.WriteLine("****FİYAT BİLGİLERİ*****");
//            Console.WriteLine("Komisyon tutarını giriniz: ");
//            Komisyon = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Fiyatı giriniz: ");
//            Fiyat = Convert.ToDouble(Console.ReadLine());

//        }

//        public void EkranaYazdir()
//        {
//            VeriAl();
//            Console.WriteLine("*****EMLAK BİLGİLERİ*****");
//            Console.WriteLine("Yapı durumunuz: " + Yapidurum);
//            Console.WriteLine("Belge ad: " + Belgead);
//            Console.WriteLine("Belge no: " + Belgeno);
//            Console.WriteLine("Emlak cinsi: " + Emlakcins);
//            Console.WriteLine("Belge sorumlunuz: " + Belgesorumlusu);
//            Console.WriteLine("Alım-Satım sorumlunuz: " + Alimsatimsorumlusu);
//            Console.WriteLine("Alım durumunuZ: " + Alimdurum);
//            Console.WriteLine("****************************");
//            Console.WriteLine("****FİYAT BİLGİLERİ*****");
//            Console.WriteLine("Komisyon tutarınız: " + Komisyon);
//            Console.WriteLine("Fiyat: " + Fiyat);

//            Console.WriteLine("Emlak alım durumuna göre fiyat: "); 
//            Method();
//            Method2();
//        }
//    }
//}
