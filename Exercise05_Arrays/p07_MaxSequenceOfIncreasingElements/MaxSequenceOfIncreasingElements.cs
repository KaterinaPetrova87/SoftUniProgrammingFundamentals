using System;
using System.Linq;

namespace p07_MaxSequenceOfIncreasingElements
{
    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currentSequenceLength = 1;
            int currentSequenceStart = 0;
            int longestSequenceLength = 1;
            int longestSequenceStart = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
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

            for (int i = longestSequenceStart; i < longestSequenceStart + longestSequenceLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
