using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }

            var result = new List<string>();

            foreach (var pair in count)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
