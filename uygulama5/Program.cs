using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Aile Bilgilerim****");

            Console.WriteLine("Anne adını giriniz :");
            string annead = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Anne yaşını giriniz :");
            int anneyas= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Baba adını giriniz :");
            string babaad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Baba adını giriniz :");
            int babayas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Çocuk adını giriniz :");
            string cocuk1ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("1.Çocuk yaşını giriniz :");
            int cocuk1yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Çocuk adını giriniz :");
            string cocuk2ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("2.Çocuk yaşını giriniz :");
            int cocuk2yas = Convert.ToInt32(Console.ReadLine());

            int yasortalama = (anneyas + babayas + cocuk1yas + cocuk2yas) / 4;

            Console.WriteLine("Anne adı: " + annead);
            Console.WriteLine("Anne yaş: " + anneyas);

            Console.WriteLine("Baba adı: " + babaad);
            Console.WriteLine("Baba yaş: " + babayas);

            Console.WriteLine("1.Çocuk adı: " + cocuk1ad);
            Console.WriteLine("1.Çocuk yaş: " + cocuk1yas);

            Console.WriteLine("2.Çocuk adı: " + cocuk2ad);
            Console.WriteLine("2.Çocuk yaş: " + cocuk2yas);

            Console.WriteLine("Aile Yaş Ortalamanız: "+ yasortalama);
            Console.ReadLine();
        }
    }
}
