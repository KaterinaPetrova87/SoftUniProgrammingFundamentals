using System;
using System.Linq;

namespace p09_ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = numbers.Length;
            if (n == 1)
            {
                Console.WriteLine($"{{ {numbers[n - 1]} }}");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine($"{{ {numbers[n / 2 - 1]} {numbers[n / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {numbers[n / 2 - 1]} {numbers[n / 2]} {numbers[n / 2 + 1]} }}");
            }
        }
    }
}
