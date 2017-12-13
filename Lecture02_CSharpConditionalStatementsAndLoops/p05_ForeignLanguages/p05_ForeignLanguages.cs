using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_ForeignLanguages
{
    class p05_ForeignLanguages
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            if(countryName == "USA" || countryName == "England")
            {
                Console.WriteLine("English");
            }
            else if (countryName == "Spain" || countryName == "Argentina" || countryName == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
