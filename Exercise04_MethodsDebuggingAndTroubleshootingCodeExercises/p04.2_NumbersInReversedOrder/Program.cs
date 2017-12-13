using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04._2_NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }

        static string Reverse(string number)
        {
            string result = "";

            for (int i = number.Length-1; i >0 ; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}
