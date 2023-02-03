using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_CW4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops through all variables in Manufacturers Enum and hands it over to PhoneTypeChecker
            foreach (Manufacturers manu in Enum.GetValues(typeof(Manufacturers)))
            {
                PhoneTypeChecker phoneTypeCheck = new PhoneTypeChecker(manu);
            }

            //Exit prompt
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
