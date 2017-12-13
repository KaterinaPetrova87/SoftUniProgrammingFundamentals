using System;
using System.Linq;

namespace p11_EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isFindEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftArray = numbers.Take(i).ToArray();
                int[] rightArray = numbers.Skip(i + 1).ToArray();

                if (leftArray.Sum() == rightArray.Sum())
                {
                    isFindEqualSums = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFindEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
