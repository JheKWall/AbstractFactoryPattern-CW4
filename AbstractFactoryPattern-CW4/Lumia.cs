using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_CW4
{
    class Lumia : ISmart
    {
        public string getName()
        {
            return "Lumia";
        }
    }
}
