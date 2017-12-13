using System;
using System.Text;
using System.Numerics;

namespace p01_ConvertFromBase_10ToBase_N
{
    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long toBase = long.Parse(input[0]);
            BigInteger numberBaseTen = BigInteger.Parse(input[1]);

            StringBuilder result = new StringBuilder();

            while (numberBaseTen > 0)
            {
                BigInteger remainder = numberBaseTen % toBase;
                result.Insert(0, remainder.ToString());
                numberBaseTen /= toBase;
            }

            Console.WriteLine(result);
        }
    }
}
