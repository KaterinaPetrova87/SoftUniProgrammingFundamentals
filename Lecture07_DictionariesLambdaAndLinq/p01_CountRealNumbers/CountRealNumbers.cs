using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            List<double> list = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToList();
            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            foreach (var number in list)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }
                    dictionary[number]++;
            }
            foreach (var number in dictionary.Keys)
            {
                Console.WriteLine($"{number} -> {dictionary[number]}");
            }
        }
    }
}
