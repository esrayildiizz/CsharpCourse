using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım6
{
    class Program
    {
        static void Main(string[] args)
        {

    
            Console.WriteLine("*** BANKA SEÇENEKLERİ****");
            Console.WriteLine("1-Garanti Bankası");
            Console.WriteLine("2-Türkiye İş Bankası");
            int banka = Convert.ToInt32(Console.ReadLine());
            switch (banka)
            {
                case 1:
                    GarantiBankasi b1 = new GarantiBankasi();
                    b1.VeriAl2();
                    b1.VeriYazdir2();
                    break;
                case 2:
                    TurkiyeIsBankasi b2 = new TurkiyeIsBankasi();
                    b2.VeriAl3();
                    b2.VeriYazdir3();
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                    break;
            }
            Console.ReadLine();
        }
    }
}
