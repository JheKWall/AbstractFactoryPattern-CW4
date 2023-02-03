using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_CW4
{
    class NokiaFactory : IPhoneFactory
    {
        //Nokia Lumia Accessor
        public ISmart getSmart()
        {
            Lumia nokiaSmart = new Lumia();
            return nokiaSmart;
        }

        //Nokia Asha Accessor
        public IDumb getDumb()
        {
            Asha nokiaDumb = new Asha();
            return nokiaDumb;
        }
    }
}
