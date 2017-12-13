using System;

namespace p09_MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOfEvenDigits = CalculateSumOfEvenDigits(number);
            int sumOfOddDigits = CalculateSumOfOddDigits(number);

            int result = CalculateSumOfEvenDigits(number) * CalculateSumOfOddDigits(number);

            Console.WriteLine(result);
        }

        public static int CalculateSumOfOddDigits(int number)
        {
            int sumOdds = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdds += lastDigit;
                }
                number /= 10;
            }

            return sumOdds;
        }

        public static int CalculateSumOfEvenDigits(int number)
        {
            int sumEvens = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEvens += lastDigit;
                }
                number /= 10;
            }

            return sumEvens;
        }
    }
}
