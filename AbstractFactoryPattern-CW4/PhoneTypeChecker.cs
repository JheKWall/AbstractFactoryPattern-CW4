using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_CW4
{
    class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            //Creates a new Factory object, sets internal factory to correct factory, sets internal manufacturer to m, and calls CheckProducts()
            switch(m)
            {
                case Manufacturers.SAMSUNG:
                    SamsungFactory samsungFactory = new SamsungFactory();
                    factory = samsungFactory;
                    manu = m;
                    CheckProducts();
                    break;

                case Manufacturers.HTC:
                    HTCFactory htcFactory = new HTCFactory();
                    factory = htcFactory;
                    manu = m;
                    CheckProducts();
                    break;

                case Manufacturers.NOKIA:
                    NokiaFactory nokiaFactory = new NokiaFactory();
                    factory = nokiaFactory;
                    manu = m;
                    CheckProducts();
                    break;

                default:
                    Console.WriteLine("Unsupported Manufacturer.\n");
                    break;
            }
        }

        public void CheckProducts()
        {
            //Smartphone Output
            Console.WriteLine(manu.ToString() + " Smartphone: " + (factory.getSmart()).getName() + "\n");

            //Dumbphone Output
            Console.WriteLine(manu.ToString() + " Dumbphone: " + (factory.getDumb()).getName() + "\n");
        }
    }
}
