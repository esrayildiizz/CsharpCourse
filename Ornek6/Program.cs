using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    class Program
    { 
      
        static void Main(string[] args)
        {

            //Calışanlardan nesne üretmeden oradaki metotları çağırabiliyoruz..
            calisanlar.Getir();
            calisanlar.Hesapla();


            //Mesela aşağıdaki console.Readline için şöyle bir açıklama yapabiliriz.
            //Console sınıfı static olarak tanımlandığı için Readline METODU nesne üretmemize gerek kalmıyor direk erişim sağlıyoruz.
            Console.ReadLine();
        }
    }
}
