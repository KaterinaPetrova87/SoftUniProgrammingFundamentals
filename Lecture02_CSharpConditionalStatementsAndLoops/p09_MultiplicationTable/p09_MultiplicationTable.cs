using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_MultiplicationTable
{
    class p09_MultiplicationTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine("{0} X {1} = {2}", n, i, result);
            }
        }
    }
}
