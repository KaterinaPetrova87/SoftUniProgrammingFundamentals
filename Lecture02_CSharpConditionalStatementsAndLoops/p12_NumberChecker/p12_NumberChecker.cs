using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_NumberChecker
{
    class p12_NumberChecker
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
