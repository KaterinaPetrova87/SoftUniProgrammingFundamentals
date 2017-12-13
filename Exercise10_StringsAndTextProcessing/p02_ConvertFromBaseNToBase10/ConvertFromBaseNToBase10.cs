using System;
using System.Linq;
using System.Numerics;

namespace p02_ConvertFromBaseNToBase10
{
    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            long baseNum = long.Parse(input[0]);
            BigInteger numsToConvert = BigInteger.Parse(input[1]);

            BigInteger sum = new BigInteger();
            int counter = 0;

            while (numsToConvert != 0)
            {
                BigInteger lastDigit = numsToConvert % 10;
                BigInteger num = BigInteger.Multiply(lastDigit, BigInteger.Pow(baseNum, counter));
                sum += num;
                numsToConvert /= 10;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }
}
