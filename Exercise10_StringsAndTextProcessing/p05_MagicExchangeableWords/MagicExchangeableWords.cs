using System;
using System.Linq;

namespace p05_MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            char[] firstStr = input[0].Distinct().ToArray();
            char[] secondStr = input[1].Distinct().ToArray();

            if (firstStr.Length == secondStr.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
