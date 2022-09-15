using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama9
{
    class Program
    {
        static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("Kullanıcı adı giriniz: ");
            string kadi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            int sifre = Convert.ToInt32(Console.ReadLine());

            if ((kadi == "admin" || kadi=="ADMİN") && sifre == 1234)
            {
                Console.WriteLine("Sayın "+ kadi + " kullanıcısı hoşgeldiniz...");
            }
            else
            {
                Console.Clear();

                Console.WriteLine("Yanlış giriş yaptınız tekrar denemek ister misiniz...");
                string devam = Console.ReadLine(  );
                if(devam=="Evet"|| devam=="EVET" || devam == "evet")
                {
                    goto basadon;
                }
                else
                {
                    Environment.Exit(0); //Console ekranını kapatır.
                }

            }

            Console.ReadLine();
        }
    }
}
