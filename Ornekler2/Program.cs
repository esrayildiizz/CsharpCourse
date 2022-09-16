using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi ürünler hakkında bilgi  almak istersiniz... ");
            Console.WriteLine("****SEÇENEKLER****");
            Console.WriteLine("ELEKTRONİK EŞYALAR (a)");
            Console.WriteLine("MOBİLYA (b)");
            Console.WriteLine("OFİS EŞYALAR (c)");
            string urun = Convert.ToString(Console.ReadLine());

            switch (urun)
            {

                case "a":
                    Console.WriteLine("Hangisi seçmek istersiniz?");
                    Console.WriteLine("1-Beyaz Eşya");
                    Console.WriteLine("2-Bilgisayar Aletleri");

                    char secim = Convert.ToChar(Console.ReadLine());

                    if (secim == '1')
                    {
                        Console.WriteLine("Lütfen beyaz eşyanızın adını girin: ");
                        string esyaad = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Lütfen beyaz eşyanızın modelini girin: ");
                        string esyamodel = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Lütfen beyaz eşyanızın markasını girin: ");
                        string esyamarka = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Lütfen beyaz eşyanızın fiyat girin: ");
                        int esyafiyat = Convert.ToInt32(Console.ReadLine());

                        if (esyaad == "Bulaşık Makinesi" && esyamarka == "Bosch")
                        {
                            Console.WriteLine("Girdiğiniz Bilgilere Göre Aşağıdaki Soruları Cevaplayınız");
                            Console.WriteLine("Lütfen bulaşık makinenizin fiyatını tekrar girin: ");
                            int bulasıkfiyat = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ÖTV Değerini Giririniz: ");
                            int ötv = Convert.ToInt32(Console.ReadLine());
                            int toplam = (bulasıkfiyat + ötv) * 15 / 100;
                            Console.WriteLine("KDV Değerini Giriniz: ");
                            int kdv = Convert.ToInt32(Console.ReadLine());
                            int kdvlifiyat = (kdv + 1000);
                            int sonfiyat = (toplam + kdvlifiyat);
                            Console.WriteLine("Ödenemniz Gereken Tutar: " + sonfiyat);
                            Console.WriteLine("İyi günler dileriz...");
                        }

                        else if (esyaad == "Bulaşık Makinesi" && esyamarka == "Arçelik")
                        {
                            Console.WriteLine("Girdiğiniz Bilgilere Göre Aşağıdaki Soruları Cevaplayınız");
                            Console.WriteLine("Lütfen bulaşık makinenizin fiyatını tekrar girin: ");
                            int bulasıkfiyat = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ÖTV Değerini Giririniz: ");
                            int ötv = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("KDV Değerini Giriniz: ");
                            int kdv = Convert.ToInt32(Console.ReadLine());
                            int hediyefiyat = 500;
                            int sonfiyat2 = (bulasıkfiyat + ötv + kdv + hediyefiyat);
                            Console.WriteLine("Ödemeniz gereken tutar: " + sonfiyat2);

                            Console.WriteLine("Hediye ister misiniz?");
                            string cevap = Convert.ToString(Console.ReadLine());
                            if (cevap == "Evet" || cevap == "EVET")
                            {
                                Console.WriteLine("Hediye Seçeneklerimiz: ");
                                Console.WriteLine("(1)ÜTÜ");
                                Console.WriteLine("(2)ROBOT");
                                Console.WriteLine("(3)AİRFERY");
                                char hediye = Convert.ToChar(Console.ReadLine());
                                if (hediye == '1')
                                {
                                    int ütüdahilfiyat = (sonfiyat2 + hediyefiyat + 500);
                                    Console.WriteLine("ütü hediyesi ile  birlikte ödemeniz gereken son fiyat: " + ütüdahilfiyat);
                                }
                                else if (hediye == '2')
                                {
                                    float robotdahilfiyat = (sonfiyat2 + hediyefiyat + 350.25f);
                                    Console.WriteLine("ütü hediyesi ile  birlikte ödemeniz gereken son fiyat: " + robotdahilfiyat);
                                }
                                else if (hediye == '3')
                                {
                                    int airfreydahilfiyat = (sonfiyat2 + hediyefiyat + 750);
                                    Console.WriteLine("ütü hediyesi ile  birlikte ödemeniz gereken son fiyat: " + airfreydahilfiyat);
                                    Console.WriteLine("Tebrikler 100 tl değerinde hediye çeki kazandınız.");
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış hediye numarasını girdiniz.Tekrar deneyiniz...");

                                }
                            }
                            else if (cevap == "Hayır" || cevap == "HAYIR")
                            {
                                Console.WriteLine("Dinlediğiniz için teşekkürler. İYİ GÜNLER DİLERİZ....");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Diğer ürünlerimize bakmak ister msisiniz?");
                            string yanit = Convert.ToString(Console.ReadLine());
                            if (yanit == "Evet")
                            {
                                Console.WriteLine("Bakabileceğiniz Seçenekler: ");
                                Console.WriteLine("X-Çamaşır Makinesi");
                                Console.WriteLine("Y-Buzdolabı");
                                switch (yanit)
                                {

                                    case "X":
                                        Console.WriteLine("Çamaşır makinesi fiyatı giriniz: ");
                                        int camasirfiyat = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Çamaşır ötv fiyat giriniz: ");
                                        int camasirötv = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Kapasite bilgisi giriniz: ");
                                        int kapasitebilgi = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enerji bilgisini giriniz: ");
                                        string enerjibilgi = Convert.ToString(Console.ReadLine());
                                        if (kapasitebilgi < 9 && enerjibilgi == "A+")
                                        {
                                            int indirimlifiyat = ((camasirfiyat + camasirötv) * 10 / 100);
                                            int sonindirim = camasirfiyat - indirimlifiyat;
                                            Console.WriteLine("İNDİRİMLİ FİYATINIZ: " + sonindirim);
                                        }
                                        else if (kapasitebilgi > 9 && enerjibilgi == "A++")
                                        {
                                            Console.WriteLine("Yıkama Programını Giriniz: ");
                                            int yikamaprogram = Convert.ToInt32(Console.ReadLine());
                                            if (yikamaprogram > 3)
                                            {
                                                int zamlifiyat1 = camasirfiyat + camasirfiyat * 25 / 100;
                                                Console.WriteLine("Ödenecek tutar: " + zamlifiyat1);
                                            }
                                            else
                                            {
                                                int zamlifiyat2 = camasirfiyat + camasirfiyat * 15 / 100;
                                                Console.WriteLine("Ödenecek tutar: " + zamlifiyat2);
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı Giriş Yaptınız .... ");
                                        }

                                        break;
                                    case "Y":
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        break;
                                    default:
                                        Console.WriteLine("Hatalı Giriş Yptınız ... ");
                                        break;
                                }
                            }
                        }
                    }
                    else if (secim == '2')
                    {
                        Console.WriteLine("Hangi elektronik eşya hakkında bilgi istersiniz?: ");
                        String secim2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("**Seçenekler**");
                        Console.WriteLine("x-notebook");
                        Console.WriteLine("y-masaüstü pc");
                        Console.WriteLine("z-tablet");


                        switch (secim2)
                        {
                            case "x":

                                Console.WriteLine("Hangi notebook hakkında bilgi istersiniz?: ");
                                String notebook = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("**Seçenekler**");
                                Console.WriteLine("(xx)-lenovo");
                                Console.WriteLine("(xxx)-dell");
                                Console.WriteLine("(xxxx)-monster");


                                switch (notebook)
                                {
                                    case "xx":
                                        Console.WriteLine("Lenova notebook fiyatı nedir?");
                                        float lenovanotebookfiyat= Convert.ToSingle(Console.ReadLine());
                                        Console.WriteLine("Harddisk bilgisini girer misiniz?");
                                        string harddisk = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("Lenovo Notebook Bilgileri - FİYAT: "+lenovanotebookfiyat+"HARDDİSK BİLGİSİ: "+ harddisk);

                                        if (harddisk=="1TB")
                                        {
                                            lenovanotebookfiyat +=lenovanotebookfiyat * 5.5f / 100;
                                            Console.WriteLine("Ödemeniz Gereken Fiyat: "+lenovanotebookfiyat);
                                        }
                                        else
                                        {
                                            lenovanotebookfiyat += lenovanotebookfiyat * 2 / 100;
                                            Console.WriteLine("Ödemeniz Gereken Fiyat: " + lenovanotebookfiyat);
                                        }
                                        break;

                                    case "xxx":
                                        Console.WriteLine("Dell notebook fiyatı nedir?");
                                        float dellnotebookfiyat = Convert.ToSingle(Console.ReadLine());
                                        Console.WriteLine("Sipariş vermek istiyorsanız sipariş türü seçiniz: ");
                                        Console.WriteLine("Seçenekler");
                                        Console.WriteLine("*-Kargo");
                                        Console.WriteLine("**-Hızlı Teslimat");
                                        string secimxxx = Convert.ToString(Console.ReadLine());
                                        switch (secimxxx)
                                        {
                                            case "*":
                                                Console.WriteLine("Kargo türünü seçiniz...");
                                                string kargotür = Convert.ToString(Console.ReadLine());
                                                if(kargotür== "mngkargo")
                                                {
                                                    Console.WriteLine("Kargonuzun ağırlığı nedir?");
                                                    int kargoagirlik = Convert.ToInt32(Console.ReadLine());
                                                    float kargoücret= Convert.ToSingle(Console.ReadLine());

                                                    if (kargoagirlik>1 && kargoagirlik<5)
                                                    {
                                                       kargoücret = (dellnotebookfiyat * 2.5f / 100);
                                                        Console.WriteLine("Kargo ücretiniz: "+kargoücret);
                                                    }
                                                    else if(kargoagirlik>=5)
                                                    {
                                                        kargoücret = (dellnotebookfiyat * 10/ 100);
                                                        Console.WriteLine("Kargo ücretiniz: " + kargoücret);

                                                    }
                                                }
                                                else if (kargotür=="yurtiçikargo")
                                                {

                                                }
                                            break;

                                            case "**":


                                            break;

                                            default:

                                             break;

                                        }

                                        break;
                                    case "xxxx":

                                        break;

                                    default:
                                        Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz.");
                                        break;

                                }
                                break;

                            case "y":
                                
                                break;


                            case "z":

                                break;

                            default:

                                break;

                        }
                    }
                     break;

                    

                case "b":

                    

                    break;

                   
                case "c":

                    break;

                default:
                            Console.WriteLine("Hatalı Giriş Yptınız Böyle Bir Urun Seceneği Yok... ");
                           break;
            }

            Console.ReadLine();
        }
    }
}
