using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .OrderByDescending(n => n)
                 .Take(3)
                 .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
