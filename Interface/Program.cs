using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon tel1=new Telefon();
            tel1.fiyat = 18000;
            tel1.marka = "iphone";
            tel1.model = "s11";
            tel1.otv = 30;
            tel1.OtvHesapla(tel1.otv, tel1.fiyat);
            Console.ReadLine();
        }
    }
}
