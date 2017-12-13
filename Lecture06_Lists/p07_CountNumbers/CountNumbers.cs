using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            int[] count = new int[1000];

            foreach (var num in numbers)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
