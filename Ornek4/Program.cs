using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    class Program
    {
        //constructor metot
        //nesneye ilk değer atamaları yapabilmek.
        //C# Constructor tanımlaması yapacağımız zaman, yapıcı metodumuzun ismi ile sınıfımızın ismi aynı olmak zorundadır.
        //Constructor(Yapıcı / Kurucu) metotlarımız, geriye herhangi bir değer döndüremediklerinden dolayı void yapıda tanımlanmalıdır.
        //Tanımlamayı yaparken erişim belirleyicisini mutlaka public olarak belirtmemiz gerekmektedir.Aksi takdirde sınıf yapımıza erişemeyeceğimiz gibi,
        //daha önce tanımladığımız yerlerde hata ile karşılaşırız.

        static void Main(string[] args)
        {
            BeyazEsya urun1 = new BeyazEsya(444,"ütü",4750);
            urun1.EsyaNo = 789;
            urun1.EsyaAdi = "çamaşır makinesi";
            urun1.Fiyat = 7800;

            Console.WriteLine("Urun no: "+urun1.EsyaNo);
            Console.WriteLine("Urun adı: "+urun1.EsyaAdi);
            Console.WriteLine("Urun fiyat: "+urun1.Fiyat);


            Console.ReadLine();
        }
    }
}
