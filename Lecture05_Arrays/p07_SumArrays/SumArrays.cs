using System;
using System.Linq;

namespace p07_SumArrays
{
    public class SumArrays
    {
        public static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] result = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
