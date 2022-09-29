using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım6
{
    class TurkiyeIsBankasi : Banka
    {
        public double ticariislemno;
        public string ticariislemtipi;
        public double ticarifaizorani;

        public override double Method(double aylikgider, double aylikgelir)
        {
            throw new NotImplementedException();
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

        public void Vergilendirme()
        {

            double vergigel = Method2(Bankatip, Hesapsayisi, Bankacilikciro);
            if (vergigel < 500000)
            {
                ticarifaizorani *= 2;
                vergigel += ticarifaizorani;
                Console.WriteLine("Yeniden vergilendirilmiş tutar : "+vergigel);

            }
            else
            {
                ticarifaizorani *= 3;
                vergigel += ticarifaizorani;
                Console.WriteLine("Yeniden vergilendirilmiş tutar : " + vergigel);
            }
        }

        public void VeriAl3()
        {
            VeriAl();
            Console.WriteLine("Ticari işelm no giriniz:");
            ticariislemno= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ticari işlem tipi giriniz:");
            ticariislemtipi = Console.ReadLine();
            Console.WriteLine("Ticari faiz orani giriniz:");
            ticarifaizorani= Convert.ToDouble(Console.ReadLine());

        }

        public void VeriYazdir3()
        {
            VeriYazdir();
            Console.WriteLine("Ticari işelm no : " + ticariislemno);
            Console.WriteLine("Ticari işlem tipi: " + ticariislemtipi);
            Console.WriteLine("Ticari faiz orani:"+ticarifaizorani);
        
        }
    }
}
