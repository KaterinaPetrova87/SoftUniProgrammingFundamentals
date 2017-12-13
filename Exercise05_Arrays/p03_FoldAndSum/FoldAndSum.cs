using System;
using System.Linq;

namespace p03_FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;

            int[] leftArray = numbers.Take(k).ToArray();
            int[] middleArray = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightArray = numbers.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] leftRightArray = leftArray.Concat(rightArray).ToArray();

            int[] sum = new int[middleArray.Length];

            for (int i = 0; i < middleArray.Length; i++)
            {
                sum[i] = leftRightArray[i] + middleArray[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
