using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    class BeyazEsya
    {
        private int esyano;
        private string esyaadi;
        private int fiyat;

        //public BeyazEsya() //constructor metot tanımladık //void gibidir.//class isminde olmalı.
        //{
        //    esyano = 555;
        //    esyaadi = "robot süpürge";
        //    fiyat = 2500;
        //}
        public BeyazEsya(int esyano,string esyaadi,int fiyat) //parametreli
        {
            this.esyano = esyano;
            this.esyaadi = esyaadi;
            this.fiyat = fiyat;
        }

        public int EsyaNo
        {
            get
            {
                return esyano;
            }
            set
            {
                if (value == 456)
                {
                    esyano = value;
                }
                else
                {
                    Console.WriteLine("Girilen değer olmadı...");
                }
            }
        }

        public string EsyaAdi
        {
            get
            {
                return esyaadi;
            }
            set
            {
                if (value == "buzdolabı")
                {
                    esyaadi = value;
                }
                else
                {
                    Console.WriteLine("Başka ürünüm yok varsayılan ürünü almak zorundasınız.");
                }
            }
        }

        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                if (value == 5000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Başka fiyat yok....");
                }
            }
        }
    }
}
