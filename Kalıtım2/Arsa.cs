//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kalıtım2
//{
//    class Arsa:Emlak
//    {
//        int parsel;
//        string arsadurum;
//        int tapu;
//        int arsam2;
//        int m2fiyat;

//        public int Parsel
//        {
//            get
//            {
//                return parsel;
//            }
//            set
//            {
//                parsel = value;
//            }
//        }

//        public string Arsadurum
//        {
//            get
//            {
//                return arsadurum;
//            }
//            set
//            {
//                arsadurum = value;
//            }
//        }

//        public int Tapu
//        {
//            get
//            {
//                return tapu;
//            }
//            set
//            {
//                tapu = value;
//            }
//        }
//        public int Arsam2
//        {
//            get
//            {
//                return arsam2;
//            }
//            set
//            {
//                arsam2 = value;
//            }
//        }
//        public int M2fiyat
//        {
//            get
//            {
//                return m2fiyat;
//            }
//            set
//            {
//                m2fiyat = value;
//            }
//        }

//        public int Arsa1(string arsadurum, int arsam2, int m2fiyat)
//        {
//            if (arsadurum == "İmarlı" || arsadurum=="İMARLI")
//            {
//                int yapimizin = arsam2 * 50 / 100;
//                int ötutar = yapimizin * m2fiyat;
//                Console.WriteLine("Ödenecek tutar: "+ötutar);
//                return ötutar;
//            }
//            else
//            {
//                int yapimizin = arsam2 * 10 / 100;
//                int ötutar = yapimizin * m2fiyat;
//                Console.WriteLine("Ödenecek tutar: "+ötutar);
//                return ötutar;
//            }
//        }

//        public void VeriAl2()
//        {
//            VeriAl();

//        }
//        public void EkranaYazdir2()
//        {
//            EkranaYazdir();
//        }
//    }
//}
