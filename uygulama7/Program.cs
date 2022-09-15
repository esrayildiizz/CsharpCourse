using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama7
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool bana true -false değer döndürür
            //bool dışarıdan veri almak istersek ToBoolean 

            bool a = 4 < 6;

            bool b = 6 > 5;

            bool c = 7 <= 7;

            bool d = 9 >= 12;

            bool e = 10 == 12;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a, b, c, d, e);
            Console.ReadLine();
        
        }
    }
}
