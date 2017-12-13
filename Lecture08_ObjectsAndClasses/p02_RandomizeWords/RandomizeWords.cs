using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(' ')
                .ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                int randomIndex = random.Next(0, words.Count);

                string tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
