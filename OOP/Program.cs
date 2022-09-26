using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Askerler asker1 = new Askerler(); //Askerler class ından asker1 adında nesne ürettik.
            //asker1.yas = 20;
            //asker1.adsoyad = "Ali ÇETİN";
            //asker1.boy = 180;
            //asker1.kilo = 60;

            //Console.WriteLine("Askerin adı soyadı:"+asker1.adsoyad);
            //Console.WriteLine("Askerin yaşı:"+asker1.yas);
            //Console.WriteLine("Askerin boyu:"+asker1.boy);
            //Console.WriteLine("Askerin kilosu:"+asker1.kilo);



            Askerler asker2 = new Askerler();
            Console.WriteLine("2.ASKERİN BİLGİLERİ");
            Console.WriteLine("Askerin yaşını giriniz: ");
            asker2.yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Askerin adını soyadını giriniz: ");
            asker2.adsoyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Askerin boyunu giriniz: ");
            asker2.boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Askerin Kilosunu giriniz: ");
            asker2.kilo = Convert.ToInt32(Console.ReadLine());



            Console.ReadLine();
        }
    }
}
