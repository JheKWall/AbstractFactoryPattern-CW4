using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_CW4
{
    class HTCFactory : IPhoneFactory
    {
        //HTC Titan Accessor
        public ISmart getSmart()
        {
            Titan htcSmart = new Titan();
            return htcSmart;
        }

        //HTC Genie (?) Accessor
        public IDumb getDumb()
        {
            Genie htcDumb = new Genie();
            return htcDumb;
        }
    }
}
