using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım6
{
    abstract class Banka
    {
        private string bankano;
        private string bankaadres;
        private string bankafaks;
        private string bankatip;
        private double bankacilikciro;
        private double hesapsayisi;
        private string hesaptip;
        private double aylikgelir;
        private double aylikgider;


        public string Bankano
        {
            get
            {
                return bankano;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    bankano = value;
                }
                else
                {
                    Console.WriteLine("Banka no hatalı...");
                }
            }
        }

        public string Bankaadres
        {
            get
            {
                return bankaadres;
            }
            set
            {
                bankaadres = value;
            }
        }

        public string Bankafaks
        {
            get
            {
                return bankafaks;
            }
            set
            {
                bankafaks = value;
            }
        }

        public string Bankatip
        {
            get
            {
                return bankatip;
            }
            set
            {
                if (value == "Kamu" || value == "Özel" )
                {
                    bankatip = value;
                }
                else
                {
                    value = "-";
                }
            }
        }

        public double Bankacilikciro
        {
            get
            {
                return bankacilikciro;
            }
            set
            {
                bankacilikciro = value;
            }
        }

        public double Hesapsayisi
        {
            get
            {
                return hesapsayisi;
            }
            set
            {
                hesapsayisi = value;
            }
        }
        public  string Hesaptip
        {
            get
            {
                return hesaptip;
            }
            set
            {
                if (value == "Bireysel" || value == "Kurumsal")
                    hesaptip = value;
                else
                {
                    value = "-";
                }
            }

        }

        public double Aylikgelir
        {
            get
            {
                return aylikgelir;
            }
            set
            {
                aylikgelir = value;
            }
        }


        public double Aylikgider
        {
            get
            {
                return aylikgider;
            }
            set
            {
                if (value<100000)
                {
                    aylikgider = value;
                }
                else
                {
                    Console.WriteLine("DİKKAT AYLIK GİDER 100 BİNDEN FAZLA...");
                }
            }
        }


        public abstract double Method(double aylikgider, double aylikgelir); //abstarctlı metot olduğu için sadece gövdesi vardır.İçini tanımlamıyoruz.Yavru class da içini doldurucaz.

        public abstract double Method2(string bankatip, double hesapsayisi, double bankacilikciro );  //abstarct lı metot olduğu için sadece gövdesi vardır.İçini tanımlamıyoruz.Yavru class da içini doldurucaz.



        public double Method3(double bankacilikciro)
        {
            double otv = bankacilikciro * 5 / 100;
            return otv;
        }


        public void VeriAl()
        {
            Console.WriteLine("Banka no giriniz: ");
            Bankano = Console.ReadLine();
            Console.WriteLine("Banka adres giriniz: ");
            Bankaadres = Console.ReadLine();
            Console.WriteLine("Banka faks giriniz: ");
            Bankafaks = Console.ReadLine();
            Console.WriteLine("Banka tipi giriniz: (Kamu /Özel)");
            Bankatip = Console.ReadLine();
            Console.WriteLine("Bankacilik ciro giriniz: ");
            Bankacilikciro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hesap sayısı giriniz: ");
            Hesapsayisi= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hesap tip giriniz: (Bireysel/Kurumsal)");
            Hesaptip= Console.ReadLine();
            Console.WriteLine("Aylık gelir giriniz: ");
            Aylikgelir= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Aylık gider giriniz: ");
            Aylikgider= Convert.ToDouble(Console.ReadLine());
        }

        public void VeriYazdir()
        {
            Console.WriteLine("Banka no: " + Bankano);
            Console.WriteLine("Banka adres: " + Bankaadres);
            Console.WriteLine("Banka faks: " + Bankafaks);
            Console.WriteLine("Banka tip: " + Bankatip);
            Console.WriteLine("Bankacilik ciro: " + Bankacilikciro);
            Console.WriteLine("Hesap sayısı: " + Hesapsayisi);
            Console.WriteLine("Hesap tip: "+Hesaptip);
            Console.WriteLine("Aylık gelir: "+Aylikgelir);
            Console.WriteLine("Aylık gider: "+Aylikgider);
        }
    }
}
