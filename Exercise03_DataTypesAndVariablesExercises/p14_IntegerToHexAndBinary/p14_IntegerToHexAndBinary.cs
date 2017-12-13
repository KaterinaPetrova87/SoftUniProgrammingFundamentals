using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14_IntegerToHexAndBinary
{
    class p14_IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = number.ToString("X").ToUpper();
            string binary = Convert.ToString(number, 2).ToUpper();

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
