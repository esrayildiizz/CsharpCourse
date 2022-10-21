using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IDurum
    {
        string marka { get; set; }   

        string model { get; set; }  

        int otv { get; set; }   

        void OtvHesapla(int otv,int fiyat);   
    }
}
