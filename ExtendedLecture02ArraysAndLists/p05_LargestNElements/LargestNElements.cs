using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_LargestNElements
{
    public class LargestNElements
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
