using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }
                    dictionary[word]++;
            }

            List<string> result = new List<string>();

            foreach (var pear in dictionary)
            {
                if (pear.Value % 2 != 0)
                {
                    result.Add(pear.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
