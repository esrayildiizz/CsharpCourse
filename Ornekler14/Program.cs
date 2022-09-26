using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler14
{
    class Program
    {
        public static void NotGiris(int sayi1,int sayi2)
        {
            int ort = (sayi1 + sayi2) / 2;
            Console.WriteLine(" İLKOKUL ORTALAMANIZ: "+ort);
        }
        public static void NotGiris(int sayi1, int sayi2,int sözlü)
        {
            int ort = (sayi1 + sayi2+sözlü) / 3;
            Console.WriteLine(" ORTAOKUL ORTALAMANIZ: " + ort);
        }
        public static void NotGiris(int sayi1, int sayi2, int sözlü,int kanaat)
        {
            int ort = (sayi1 + sayi2 + sözlü+kanaat) / 4;
            Console.WriteLine(" LİSE ORTALAMANIZ: " + ort);
        }

        static void Main(string[] args)
        {
            NotGiris(50,45);
            NotGiris(50,45,80);
            NotGiris(50,45,75,60);
            Console.ReadLine();
        }
    }
}
