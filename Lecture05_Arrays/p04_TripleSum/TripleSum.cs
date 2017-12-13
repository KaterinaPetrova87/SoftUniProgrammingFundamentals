using System;
using System.Linq;

namespace p04_TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool containsSum = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        containsSum = true;
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    }
                }
            }
            if (!containsSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
