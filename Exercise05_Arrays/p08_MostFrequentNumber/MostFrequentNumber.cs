using System;
using System.Linq;

namespace p08_MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] count = new int[65535];

            foreach (int number in numbers)
            {
                count[number]++;
            }

            int countMax = count.Max();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (count[numbers[i]] == countMax)
                {
                    Console.WriteLine(numbers[i]);
                    break;
                }
            }
        }
    }
}

