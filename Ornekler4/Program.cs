using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler4
{
    class Program
    {
        static void Main(string[] args)
        {


            //Yıldızlarla şekil çizme
            //ornek1
            Console.WriteLine("BİR SAYI GİRİN: ");
            int sayi= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=sayi; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
