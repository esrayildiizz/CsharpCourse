//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kalıtım
//{
//    class Hayvan //temel class ,base class,ana class, super class
//    {
//        string hayvanad;
//        int ayaksayisi;
//        string cins;
//        int yas;
//        int kilo;

//        public string Ad
//        {
//            get
//            {
//                return hayvanad;
//            }
//            set
//            {
//                hayvanad = value;
//            }
//        }

//        public int Asayisi
//        {
//            get
//            {
//                return ayaksayisi;
//            }
//            set
//            {
//                ayaksayisi = value;
//            }
//        }

//        public string Cins
//        {
//            get
//            {
//                return cins;
//            }
//            set
//            {
//                cins = value;
//            }
//        }

//        public int Yas
//        {
//            get
//            {
//                return yas;
//            }
//            set
//            {
//                yas = value;
//            }
//        }

//        public int Kilo
//        {
//            get
//            {
//                return kilo;
//            }
//            set
//            {
//                if (value>=10 && value<=20)
//                {
//                    kilo = value;
//                }
//                else
//                {
//                    kilo = value;
//                    Console.WriteLine("Veterinere başvurun.");
//                }
//            }

//        }


//        public void Ozellikler()
//        {
//            Console.WriteLine("Hayvanlarımız evcildir.");
//            Console.WriteLine("Tüm aşılar yapılmıştır..");
//            Console.WriteLine("Aşı kartlarını lütfen takip ediniz.....");
//        }


//    }
//}
