using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama8
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ornek1
            Console.WriteLine("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mezuniyetinizi giriniz:");
            string mezuniyet = Console.ReadLine();

            if (yas > 18  && mezuniyet=="lisans")
            {
                Console.WriteLine("Başvuru yapabilirsiniz...");
            }
            else
            {
                Console.WriteLine("Katılım sağlanamaz...");
            }
            Console.ReadLine();






        }
    }
}
