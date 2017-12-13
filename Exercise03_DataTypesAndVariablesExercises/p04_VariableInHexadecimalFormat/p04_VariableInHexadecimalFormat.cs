using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_VariableInHexadecimalFormat
{
    class p04_VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine(number);
        }
    }
}
