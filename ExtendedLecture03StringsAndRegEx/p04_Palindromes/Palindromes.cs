using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p04_Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();

            foreach (var word in text)
            {
                string reversed = ReverseWord(word);
                if (word == reversed)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result.Distinct().OrderBy(x => x)));
        }

        private static string ReverseWord(string word)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed.Append(word[i]);
            }

            return reversed.ToString();
        }
    }
}
