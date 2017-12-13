using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_SearchForANumber
{
    class p03_SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> result = numbers.Take(array[0]).ToList();
            result.RemoveRange(0, array[1]);

            if (result.Contains(array[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
