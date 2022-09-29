//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kalıtım3
//{
//    class AkilliTelelefonlar:Telefonlar
//    {
//        int kamereinc;
//        string yuztanima;
//        bool pokuma;
//        string odemeturu;
       

//        public int Kamerainc
//        {
//            get
//            {
//                return kamereinc;
//            }
//            set
//            {
//                kamereinc = value;
//            }
//        }

//        public string Yuztanima
//        {
//            get
//            {
//                return yuztanima;
//            }
//            set
//            {
//                yuztanima = value;
//            }
//        }

//        public bool Pokuma
//        {
//            get
//            {
//                return pokuma;
//            }
//            set
//            {
//                pokuma = value;
//            }
//        }

//        public string Odemeturu
//        {
//            get
//            {
//                return odemeturu;
//            }
//            set
//            {
//                odemeturu = value;
//            }
//        }

        
//        public double Sonodeme(string odemeturu, double fiyat)
//        {
//            if (odemeturu == "Peşin" || odemeturu=="peşin")
//            {
//                return fiyat;
//            }
//            else
//            {
//                Console.WriteLine("Taksit seçiniz: ");
//                double taksit = Convert.ToDouble(Console.ReadLine());
//                fiyat /= taksit;
//                return fiyat;
//            }
//        }

//        public void VeriSat()
//        {
//            VerilAl();
//            Console.WriteLine("Kamere inç giriniz: ");
//            Kamerainc=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Yüz tanıma durumunu giriniz:");
//            Yuztanima = Console.ReadLine();
//            Console.WriteLine("Okuma durumu giriniz:");
//            Pokuma = Convert.ToBoolean(Console.ReadLine());
//            Console.WriteLine("Ödeme türünü giriniz: (Peşin/Taksit)"); 
//            Odemeturu = Console.ReadLine();
//        }

//        public void EkranaAt()
//        {
//            Console.Clear();
//            EkranaYazdır();
//            double a = sonfiyat;
//            double islem = Sonodeme(Odemeturu, a);
//            Console.WriteLine("Taksitli tutar: "+islem);

//        }

//    }
//}
