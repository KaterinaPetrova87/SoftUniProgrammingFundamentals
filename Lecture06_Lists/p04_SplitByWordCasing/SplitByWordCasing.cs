using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine()
                 .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }
                 , StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in text)
            {
                if (word.All(char.IsLower))
                {
                    lowerCase.Add(word);
                }
                else if (word.All(char.IsUpper))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
