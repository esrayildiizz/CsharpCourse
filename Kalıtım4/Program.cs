using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Motorlutasitlar sınıfından nesne üretemeyiz.
            //soyut class yaptık ve bu classtan nesne üretemeyiz.
            //nesne üretemeyince içindeki field ve propertylere ulaşamayız. o yüzden kalıtım bırakarak erişim sağlarız.
            //bunun tam tersi sealed class.tır.


            Motorsiklet m1 = new Motorsiklet();
            
        }
    }
}
