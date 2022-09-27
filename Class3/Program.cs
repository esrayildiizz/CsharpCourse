using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kargo şirketini giriniz: ");
            Console.WriteLine("***SEÇENEKLER****");
            Console.WriteLine("a-yurtici");
            Console.WriteLine("b-mng");
            Console.WriteLine("c-ptt");
            string kargo = Convert.ToString(Console.ReadLine());

            switch (kargo)
            {
                case "a":
                    yurtici y = new yurtici();
                    y.EkranaYazdir();
                    break;
                case "b":
                    mng m = new mng();
                    m.EkranaYazdir();
                    break;
                case "c":
                    ptt p = new ptt();
                    p.EkranaYazdir();
                    break;
                default: Console.WriteLine("Hatalı Giriş Yaptınız");
                          break;
            }
            Console.ReadLine();
        }

    }
}
