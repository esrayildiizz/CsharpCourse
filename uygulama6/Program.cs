using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Not Bilgilerim****");

            Console.WriteLine("1.Ders adını giriniz: ");
            string ders1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("1.Ders karakterini giriniz: ");
            Console.WriteLine("Matematik için 'M' / Fen Bilgisi için 'F' / Sosyal Bilgisi için 'S' / Türkçe için 'T' giriniz: ");
            char ders1karakter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("1.Ders vize notunuzu giriniz: ");
            float vizenot1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1.Ders final notunuzu giriniz: ");
            float finalnot1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("2.Ders adını giriniz: ");
            string ders2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("2.Ders karakterini giriniz: ");
            Console.WriteLine("Matematik için 'M' / Fen Bilgisi için 'F' / Sosyal Bilgisi için 'S' / Türkçe için 'T' giriniz: ");
            char ders2karakter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("2.Ders notunuzu giriniz: ");
            float vizenot2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("2.Ders final notunuzu giriniz: ");
            float finalnot2 = Convert.ToSingle(Console.ReadLine());

            float ders1ortalama = ((vizenot1 * 40/100)+(finalnot1*60/100));
            float ders2ortalama = ((vizenot2 * 40/100)+(finalnot2*60/100));

            Console.WriteLine("****Not Ortalamalarım****");


            Console.WriteLine("Ders1 karakteriniz : "+ ders1karakter + " Ders1 ortalamanız:" + ders1ortalama);

            Console.WriteLine("Ders2 karakteriniz : " + ders2karakter + " Ders1 ortalamanız:" + ders2ortalama);

            Console.ReadLine();
        }
    }
}
