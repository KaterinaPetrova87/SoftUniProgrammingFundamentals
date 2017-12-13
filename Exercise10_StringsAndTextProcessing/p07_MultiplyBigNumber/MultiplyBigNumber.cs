using System;
using System.Text;

namespace p07_MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == "0" || firstNumber == string.Empty || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = 0;
            var oneInMind = 0;
            var remainder = 0;

            var sb = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                result = (int.Parse(firstNumber[i].ToString()) * secondNumber + oneInMind);
                oneInMind = result / 10;
                remainder = result % 10;

                sb.Append(remainder);

                if (i == 0 && oneInMind != 0)
                {
                    sb.Append(oneInMind);
                }
            }

            var resultToCharArray = sb.ToString().ToCharArray();
            Array.Reverse(resultToCharArray);

            Console.WriteLine(new string(resultToCharArray));
        }
    }
}
