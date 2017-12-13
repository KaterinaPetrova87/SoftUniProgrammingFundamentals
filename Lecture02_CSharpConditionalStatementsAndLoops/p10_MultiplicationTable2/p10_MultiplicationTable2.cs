using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_MultiplicationTable2
{
    class p10_MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;

            if (num2 > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num1, num2, num1 * num2);
            }
            else
            {
                for (int i = num2; i <= 10; i++)
                {
                    result = num1 * i;
                    Console.WriteLine("{0} X {1} = {2}", num1, i, result);
                }
            }
        }
    }
}
