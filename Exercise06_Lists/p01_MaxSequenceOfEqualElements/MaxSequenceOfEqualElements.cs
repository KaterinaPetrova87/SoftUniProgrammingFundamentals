using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int currentSequenceStart = 0;
            int currentSequenceLength = 1;
            int longestSequenceStart = 0;
            int longestSequenceLength = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceStart = currentSequenceStart;
                    }
                }
                else
                {
                    currentSequenceLength = 1;
                    currentSequenceStart = i + 1;
                }
            }
            List<int> result = numbers.Skip(longestSequenceStart).Take(longestSequenceLength).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
