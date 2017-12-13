using System;
using System.Linq;

namespace p01_LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int leftCount = GetLargestCommonEnd(firstArray, secondArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCount = GetLargestCommonEnd(firstArray, secondArray);

            Console.WriteLine(Math.Max(leftCount, rightCount));
        }

        public static int GetLargestCommonEnd(string[] first, string[] second)
        {
            int shorter = Math.Min(first.Length, second.Length);
            int count = 0;
            for (int i = 0; i < shorter; i++)
            {
                if (first[i] == second[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
