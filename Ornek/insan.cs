using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    abstract class insan
    {

        //ana class virtual sanal bir method

        public virtual void Selamver()    //ana class ta virtual.
        {
            Console.WriteLine("İnsanlar selamlaşır...");

        }
    }
}
