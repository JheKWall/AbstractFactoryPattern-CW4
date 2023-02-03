using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_CW4
{
    class SamsungFactory : IPhoneFactory
    {
        //Samsung GalaxyS2 Accessor
        public ISmart getSmart()
        {
            GalaxyS2 samsungSmart = new GalaxyS2();
            return samsungSmart;
        }

        //Samsung Primo Accessor
        public IDumb getDumb()
        {
            Primo samsungDumb = new Primo();
            return samsungDumb;
        }
    }
}
