using System;
using System.Numerics;

namespace p13_Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            CalculatesFactorial(number);
        }

        static void CalculatesFactorial(BigInteger number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

        }
    }
}
