using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_BooleanVariable
{
    class p05_BooleanVariable
    {
        static void Main(string[] args)
        {
            bool word = Convert.ToBoolean(Console.ReadLine());
            if (word)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
