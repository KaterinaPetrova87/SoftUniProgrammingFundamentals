using System;
using System.Text;

namespace p06_SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstStr = Console.ReadLine().TrimStart('0');
            var secondStr = Console.ReadLine().TrimStart('0');

            var maxLength = Math.Max(firstStr.Length, secondStr.Length);

            firstStr = firstStr.PadLeft(maxLength, '0');
            secondStr = secondStr.PadLeft(maxLength, '0');

            var first = firstStr.ToCharArray();
            var second = secondStr.ToCharArray();

            StringBuilder sb = new StringBuilder();

            var remainder = 0;
            var oneInMind = 0;

            for (int i = maxLength - 1; i >= 0; i--)
            {

                var firstNumber = int.Parse(first[i].ToString());
                var secondNumber = int.Parse(second[i].ToString());

                firstNumber += oneInMind;
                oneInMind = 0;

                if (firstNumber + secondNumber < 10)
                {
                    sb.Append(firstNumber + secondNumber);
                }
                else
                {
                    remainder = ((firstNumber + secondNumber) % 10);
                    sb.Append(remainder);
                    oneInMind = 1;
                }
            }
            if (oneInMind != 0)
            {
                sb.Append(oneInMind);
            }
            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);

            Console.WriteLine(string.Join("", result));
        }
    }
}
