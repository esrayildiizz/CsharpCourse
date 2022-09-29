using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım5
{
    sealed class yuktasitlar : motorlutasitlar
    {
        //sealed class tan ben kalıtım bırakamam.
        //direk kendi classını üreterek kullanılabilir..
        //kalıtım alır.
        public override void Metot(string a, string b)
        {
            throw new NotImplementedException();
        }

        public override int metot2(int fiyat)
        {
            throw new NotImplementedException();
        }
    }
}
