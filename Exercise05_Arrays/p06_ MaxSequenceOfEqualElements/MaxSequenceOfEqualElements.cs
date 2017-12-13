using System;
using System.Linq;

namespace p06__MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currentSequenceStart = 0;
            int currentSequenceLength = 1;
            int longestSequenceStart = 0;
            int longestSequenceLength = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
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
                    currentSequenceStart = i + 1;
                    currentSequenceLength = 1;
                }
            }

            for (int i = longestSequenceStart; i < longestSequenceStart + longestSequenceLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
