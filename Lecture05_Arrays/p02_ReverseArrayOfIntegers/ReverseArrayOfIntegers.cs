using System;
using System.Linq;

namespace p02_ReverseArrayOfIntegers
{
    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Array.Reverse(numbers);
            //Console.WriteLine(string.Join(" ", numbers));

            //numbers = numbers.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", numbers));

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
