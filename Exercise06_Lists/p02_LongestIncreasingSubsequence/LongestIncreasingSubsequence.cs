using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var longestIncreasingSubsequence = FindLogestIncreasingSubsequence(numbers);
            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));

        }

        public static int[] FindLogestIncreasingSubsequence(int[] numbers)
        {
            int[] lengths = new int[numbers.Length];
            int[] previous = new int[numbers.Length];

            int bestLength = 0;
            int lastIndex = -1;

            for (int anchor = 0; anchor < numbers.Length; anchor++)
            {
                lengths[anchor] = 1;
                previous[anchor] = -1;

                int anchorNum = numbers[anchor];

                for (int i = 0; i < anchor; i++)
                {
                    int currentNum = numbers[i];
                    if (currentNum < anchorNum && lengths[i] + 1 > lengths[anchor])
                    {
                        lengths[anchor] = lengths[i] + 1;
                        previous[anchor] = i;
                    }
                }

                if (lengths[anchor] > bestLength)
                {
                    bestLength = lengths[anchor];
                    lastIndex = anchor;
                }
            }
            List<int> longestIncreasingSubsequence = new List<int>();

            while (lastIndex > -1)
            {
                longestIncreasingSubsequence.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestIncreasingSubsequence.Reverse();
            return longestIncreasingSubsequence.ToArray();
        }
    }
}
