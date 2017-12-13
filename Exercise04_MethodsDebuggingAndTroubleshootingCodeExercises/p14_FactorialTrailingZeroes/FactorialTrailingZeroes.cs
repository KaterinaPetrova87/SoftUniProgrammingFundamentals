using System;
using System.Numerics;

namespace p14_FactorialTrailingZeroes
{
    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(CountZeroInFactorial(factorial));
        }

        static int CountZeroInFactorial(BigInteger factorial)
        {
            int counter = 0;
            BigInteger lastDigit = factorial % 10;
            while (lastDigit == 0)
            {
                counter++;
                factorial /= 10;
                lastDigit = factorial % 10;
            }
            return counter;
        }
    }
}
