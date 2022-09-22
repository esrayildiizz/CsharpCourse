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

            //int[] sayilar = new int[10];
            //int adet5 = 0;
            //int adet7 = 0;
            //float toplam = 0;
            //float ort = 1;

            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine(i + 1 + ". Sayıyı Girin: ");
            //   sayilar[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.Clear();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + 1 + " . sayı: " + sayilar[i]);
            //    if (sayilar[i] % 5 == 0)
            //    {
            //        adet5++;
            //    }
            //    else if (sayilar[i] % 7 == 0)
            //    {
            //        adet7++;
            //    }
            //    toplam = toplam + sayilar[i];
            //    ort = toplam / 10;
            //}
            //Console.WriteLine("5'e bölünen sayılar: "+adet5);
            //Console.WriteLine("7'e bölünen sayılar: "+adet7);
            //Console.WriteLine("Sayıların ortaması: " + ort);
            //Console.ReadLine();






            //ornek6

            //girilen 5 sayının karelerini, sayıların toplamını ve karelerinin toplamını bulan prog.

            //int[] sayilar = new int[5];
            //float gtoplam = 0;
            //int sonuc1 = 1;
            //int sonuc2 = 1;
            //int sonuc3 = 1;
            //int sonuc4 = 1;
            //int sonuc5 = 1;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(i + 1 + ".Elemanı  Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Clear();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + 1 + ".eleman: " + sayilar[i]);

            //    sonuc1 = sayilar[0] * sayilar[0];

            //    sonuc2 = sayilar[1] * sayilar[1];

            //    sonuc3 = sayilar[2] * sayilar[2];

            //    sonuc4 = sayilar[3] * sayilar[3];

            //    sonuc5 = sayilar[4] * sayilar[4];

            //    gtoplam = (sonuc1 + sonuc2 + sonuc3 + sonuc4 + sonuc5);
            //}
            //Console.WriteLine();
            //Console.WriteLine("1.elemanın karesi: " + sonuc1);
            //Console.WriteLine("2.elemanın karesi: " + sonuc2);
            //Console.WriteLine("3.elemanın karesi: " + sonuc3);
            //Console.WriteLine("4.elemanın karesi: " + sonuc4);
            //Console.WriteLine("5.elemanın karesi: " + sonuc5);
            //Console.WriteLine();
            //Console.WriteLine("Tüm Sayıların karelerinin toplamı: "+gtoplam);

            //Console.ReadLine();







            //ornek7

            //5 elemanlı dizideki negatif sayıları pozitife ceviren prog.


            //int[] sayilar = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(i + 1 + ". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(i + 1 + ".sayı: " + sayilar[i]);

            //    if (sayilar[i] < 0)
            //    {
            //        int nsayi= sayilar[i] *(-1);
            //        Console.WriteLine("yeni sayi: "+nsayi);
            //    }
            //    else
            //    {
            //        int psayi = sayilar[i] * (1);
            //        Console.WriteLine("yeni sayi: "+psayi);
            //    }

            //}
            //Console.ReadLine();







            //ornek8

            // 20 elemanlı dizimize random olarak 1 ile 10 arasında deger atayan ve kullanıcının girdiği değere göre
            // kaç adet olduğunu gösteren yok ise de  bulunamadı diyen prog.


            //Random rastgele = new Random();
            //int[] sayilar = new int[20];
            //int adet = 0;


            //for (int i = 0; i < 20; i++)
            //{
            //    sayilar[i] = rastgele.Next(1, 10);
            //}

            //Console.WriteLine("Sayı giriniz: " );
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < 20; i++)
            //{ 
            //    if (sayilar[i] ==sayi)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine("Girdiğiniz sayı dizide " + adet + " adettir.");
            //Console.WriteLine();
            //if (adet == 0)
            //{
            //    Console.WriteLine(sayi + "değerini bulamadık..");
            //}

            //Console.ReadLine();









            //ornek9

            //girilen 10 üründen fiyatı 2 basamaklıysa %20 zam 
            //3 basamaklıysa %50 zam yapan prog.

            //int[] fiyatlar = new int[10];
            //int zam = 1;
            //int yfiyat = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(i + 1 + ".ürünün fiyatını girin: ");
            //    fiyatlar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (fiyatlar[i]>9 && fiyatlar[i] <100)
            //    {
            //        zam = fiyatlar[i] * 20 / 100;
            //        yfiyat = fiyatlar[i] + zam;
            //    }
            //    else if(fiyatlar[i] >99 && fiyatlar[i] < 1000)
            //    {
            //         zam = fiyatlar[i] * 50 / 100;
            //        yfiyat = fiyatlar[i] + zam;
            //    }

            //    Console.WriteLine(i + 1 + ".ürünün zamli fiyatı: " +yfiyat);
            //}
            //Console.ReadLine();







            //ornek10

            //dizinin boyutunu kullanıcının girdiği değere göre belirleyen ve girilen sayıların sonu sıfır olanların
            //adedini ,olmayanların ise 5'e bölünenlerin adedini veren prog.



            //Console.WriteLine(" LÜTFEN DİZİNİN ELEMAN SAYISINI GİRİNİZ:");
            //int sayi= Convert.ToInt32(Console.ReadLine());

            //int[] sayilar = new int[sayi];

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.Write(i + 1 + ". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sayac1 = 0;
            //int sayac2 = 0;

            //for (int i = 0; i < sayi; i++)
            //{
            //    if (sayilar[i] % 10 == 0)
            //    {
            //        sayac1++;

            //    }
            //    else if (sayilar[i]%10!=0)
            //    {
            //        if(sayilar[i] % 5 == 0)
            //        {
            //            sayac2++;

            //        }
            //    }            }
            //Console.WriteLine("Sonu sıfır olan sayılar: " + sayac1);
            //Console.WriteLine("Sonu sıfır olmayıp 5'e bölünen sayılar: " + sayac2);
            //Console.ReadLine();











            //ornek11

            //random gelen sayıların birbirinden farklı olarak atanması.

            //Random rastgele = new Random();
            //int[] dizi = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    dizi[i] = rastgele.Next(1, 100);

            //    for (int a = 0; a < i; a++)
            //    {
            //        if (dizi[a] == dizi[i])
            //        {
            //            i--;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("dizi benzersiz sayılarla dolduruluyor..");
            //Console.WriteLine("dizi dolduruldu. ekrana yazdırılıyor...");

            //for (int esra = 0; esra < 10; esra++)
            //{

            //    Console.WriteLine(dizi[esra]);

            //}

            //Console.ReadLine();











            //ornek12


            //Console.WriteLine(" LÜTFEN DİZİNİN ELEMAN SAYISINI GİRİNİZ:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int[] sayilar = new int[sayi];


            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.Write(i + 1 + ". Sayıyı Girin: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("tek sayılar:");
            //for (int i = 0; i < sayi; i++)
            //{
            //    if (sayilar[i] % 2 == 1)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }

            //}

            //Console.WriteLine("Çift sayılar:");
            //for (int i = 0; i < sayi; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }

            //}
        
            //Console.ReadLine();


























        }
    }
}
