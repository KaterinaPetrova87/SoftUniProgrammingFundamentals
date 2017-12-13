using System;
using System.Numerics;

namespace p03_BigPower
{
    public class BigPower
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger power = BigInteger.Pow(new BigInteger(n), n);

            Console.WriteLine(power);
        }
    }
}
