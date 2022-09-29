//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kalıtım3
//{
//    class Telefonlar //ana class
//    {
//        int urunno;
//        double fiyat;
//        string marka;
//        string model;
//        double kdv;
//        public double sonfiyat;

//        public int Urunno
//        {
//            get
//            {
//                return urunno;
//            }
//            set
//            {
//                if (value.ToString().Length == 3)
//                    urunno = value;
//                else
//                {
//                    Console.WriteLine("Ürün no yanlış...");
//                }
//            }
//        }

//        public string Marka
//        {
//            get
//            {
//                return marka;
//            }
//            set
//            {
//                marka = value;
//            }
//        }

//        public string Model
//        {
//            get
//            {
//                return model;
//            }
//            set
//            {
//                model = value;
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
//        public double Kdv
//        {
//            get
//            {
//                return kdv;
//            }
//            set
//            {
//                kdv = value;
//            }
//        }

//        public double OtvHesapla(double fiyat, double kdv)
//        {
//            if (fiyat > 10000 && fiyat < 20000)
//            {
//                fiyat += fiyat * kdv / 100;
//                fiyat += fiyat * 8 / 100;  //8 otv miktarı kendimiz girdik
//                return fiyat;
//            }
//            else if (fiyat > 20000)
//            {
//                fiyat += fiyat * kdv / 100;
//                fiyat += fiyat * 15 / 100;  //15 otv miktarı kendimiz girdik
//                return fiyat;
//            }
//            else
//            {
//                return fiyat;
//            }
//        }

//        public double MarkaSorgula(string marka, double fiyat)
//        {
//            if (marka == "Samsung")
//            {
//                fiyat -= fiyat * 25 / 100;
//                return fiyat;
//            }
//            else if (marka == "İphone")
//            {
//                fiyat += fiyat * 5 / 100;
//                return fiyat;
//            }
//            else
//            {
//                return fiyat;
//            }
//        }

//        public void VerilAl()
//        {
//            Console.WriteLine("Ürün no giriniz: ");
//            Urunno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Marka giriniz: ");
//            Marka = Console.ReadLine();
//            Console.WriteLine("Model giriniz: ");
//            Model = Console.ReadLine();
//            Console.WriteLine("Fiyat giriniz: ");
//            Fiyat = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Kdv giriniz: ");
//            Kdv = Convert.ToDouble(Console.ReadLine());
//        }

//        public void EkranaYazdır()
//        {
//            Console.WriteLine("Ürün no: " + Urunno);
//            Console.WriteLine("Marka: " + Marka);
//            Console.WriteLine("Model: " + Model);
//            Console.WriteLine("Fiyat: " + Fiyat);
//            Console.WriteLine("Kdv: " + Kdv);

//            double islem = OtvHesapla(Fiyat,Kdv);
//            double islem2 = MarkaSorgula(Marka, islem);
//            sonfiyat = islem2;
//            Console.WriteLine("ÖDEMENİZ GEREKEN TUTAR: "+islem2);
//        }

//    }
//}
