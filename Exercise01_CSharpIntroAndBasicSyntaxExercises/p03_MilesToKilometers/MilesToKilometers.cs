using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var miles = 1.60934;
            var kilometers = km * miles;

            Console.WriteLine("{0:F2}", kilometers);
        }
    }
}
