using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler

//Değişkenlerde aynı anda tek bir değer tutulabilir. Fakat bazı durumlarda birden fazla veri saklanması istenebilir. Bu durumda aynı veri türünde verilerin saklanabileceği dizi tanımlaması gerekir. Dizi tanımlarken kaç elemanlı olduğunun belirlenmesi gerekir.
//İnt[] sayılar = new int[5];
//            Sayılar isimli 5 elemandan oluşan bir dizi tanımlanmıştır.

//Bu şekilde tanımla yerine diziye ilk değer ataması yapılarak da tanımlama yapılabilir. Böyle bir tanımlama yapıldığında dizinin eleman sayısı girilen değerlere göre belirlenir.Değerler arasında virgül kullanılır. 
//Dizi kullanımı:
//Değişken tipi[] değişken adı = new değişken tipi[eleman sayısı];
//        Örn: int[] dizi = new int[25];
//            Kodda da int türünden 25 elemanlı dizi adında bir dizi tanımlandı ve dizinin her bir elemanına int türünün varsayılan değeri atandı.Varsayılan değerler, sayısal türler için 0, object türü için NULL(yokluk), string türü için “ ”, char için ‘ ’ (boşluk)ve BOOL için false değerleridir.

//Bütün dizilerin birinci elemanı 0.İndeksidir.Dizi dizisinin birinci elemanına dizi[0], 25.Elemanına dizi[24] yazarak erişilebilir ve bu dizi elemanlarını bir değişkenmiş gibi kullanırız.
//Örnek:
//            String[] ad = new string[20];
//            Veya int[] dizi;
//            Dizi = new int[25];
//        Örn:
//            String[] ad;
//            Ad = new string[20];
//            İnt[] sayılar = { 3, 5, 8, 6 };
//            Sayılar dizisi
//3
//5
//8
//6

//Dizilerin herhangi bir elemanına değer atamak ya da herhangi bir elemanın değerini okumak istersek köşeli parantezler içerisinde indis değerini belirtiriz. Örneğin sayılar dizisinin 3.Elemanını ekrana yazdırmak istediğimizde aşağıdaki gibi bir kullanım gereklidir. Dizinin 3.elemanını ekrana yazdırmak için indis değerini kullanmalıyız.
//Dizi çeşitleri 3 e ayrılır.
//1 - Tek boyutlu diziler
//2 - Çok boyutlu diziler
//3 - Düzensiz diziler
// Dizinin kuralları:
//            1 - Diziler hafızaya toplu halde yerleştikleri için tanımlanın bir dizinin eleman sayısı programın hafızada kapladığı alana doğrudan etki edecektir.
//2 - Elemanları gösteren sayıların(indis) sıfırdan başlayıp, eleman sayısının bir eksiğine kadar devam etmesidir. Bu alt ve üst sınırlara azami dikkat edilmesi gerekmektedir.
//3 - Dizilere eleman atarken ve dizinin elemanlarını kullanırken dizi boyutu sayısınca iç içe for for döngüsü kullanma gereği hemen aklıma gelmelidir.
// * *C ve C++ programlama dillerinde olduğu gibi dizilerin  elemanlarına aşağıdaki gibi de değer atayabiliriz:
//String dizi1 ={“Bir”,”iki”,”üç”};
//            İnt dizi2 = { 2, -4, 6 };
//            Float[] dizi3 = { 2f, 1.2f, 7f };
//            Double[] dizi4 = { 2d, 5.5d, 66.9d };

//            Diziler yukarıdaki şekilde tanımlandığında söz konusu dizilerin eleman sayısı yazılan eleman sayısı olur.Örneğin yukarıdaki örneklerde üç dizinin de eleman sayısı üçtür ve dördüncü elemana ulaşmak istersek programımız çalışma zamanında hata verir.Bu şekilde dizi elemanlarına değişken ve ifadelerde atanabilir.







            //ornek1

            //int[] sayilar = { 4, 1, 7, 23, 14, 51};
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine("dizi elemanları: "+i);
            //}

            //Console.Read();






            //ornek2

            //int[] sayilar = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1+". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 0; i < 5; i++) //dizi içindeki verileri yazdırıyoruz.
            //{
            //    Console.WriteLine(i + 1 + ". İsim: "+ sayilar[i]);
            //}
            //Console.ReadLine();








            //ornek3

            //string [] isimler = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1+". İsmi Girin: ");
            //    isimler[i] = Convert.ToString(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 4; i>=0; i--)
            //{
            //    Console.WriteLine("****Sıralama****");
            //    Console.WriteLine(i+1+" . isimler: " + isimler[i]);
            //}

            //Console.ReadLine();






            //ornek4
            //6 elemanlı dizinin elemanlarının toplamını ve ortalamasını bulan prog.

            //int[] sayilar = new int[6];
            //float toplam = 0;
            //float ort = 1;

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(i + 1 + ". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.Clear();
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(i + 1 + " . sayı: " + sayilar[i]);
            //    toplam = toplam + sayilar[i];
            //    ort = toplam / 6;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Sayıların toplam: "+toplam);
            //Console.WriteLine("Sayıların ortaması: " + ort);
            //Console.ReadLine();





            //ornek5
            //diziye dışarıdan girilen 10 sayının 5 ve 7 ye bölünenlerin adedi bölünmeyenlerin ise ort veren program

            int[] sayilar = new int[10];
            int adet5 = 0;
            int adet7 = 0;
            float toplam = 0;
            float ort = 1;

            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine(i + 1 + ". Sayıyı Girin: ");
               sayilar[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " . sayı: " + sayilar[i]);
                if (sayilar[i] % 5 == 0)
                {
                    adet5++;
                }
                else if (sayilar[i] % 7 == 0)
                {
                    adet7++;
                }
                toplam = toplam + sayilar[i];
                ort = toplam / 10;
            }
            Console.WriteLine("5'e bölünen sayılar: "+adet5);
            Console.WriteLine("7'e bölünen sayılar: "+adet7);
            Console.WriteLine("Sayıların ortaması: " + ort);
            Console.ReadLine();











        }
    }
}
