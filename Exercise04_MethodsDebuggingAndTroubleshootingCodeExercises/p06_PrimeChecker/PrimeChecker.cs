using System;

namespace p06_PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            long maxNum = (long)Math.Sqrt(number);

            for (int i = 2; i <= maxNum; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
