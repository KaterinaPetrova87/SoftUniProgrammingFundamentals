using System;
using System.Linq;

namespace p04_CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            string firstString = input[0];
            string secondString = input[1];

            int totalSum = CalculateSumOfCharacters(firstString, secondString);

            Console.WriteLine(totalSum);
        }

        public static int CalculateSumOfCharacters(string first, string second)
        {
            var maxLength = Math.Max(first.Length, second.Length);
            int totalSum = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (first.Length < i + 1)
                {
                    totalSum += second[i];
                }
                else if (second.Length < i + 1)
                {
                    totalSum += first[i];
                }
                else
                {
                    totalSum += first[i] * second[i];
                }
            }
            return totalSum;
        }
    }
}
