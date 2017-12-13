using System;
using System.Linq;

namespace p08_LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                 .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            decimal sum = 0m;

            for (int i = 0; i < input.Length; i++)
            {
                char leftLetter = char.Parse(input[i].Substring(0, 1));
                char rightLetter = char.Parse(input[i].Substring(input[i].Length - 1));
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));

                if (char.IsUpper(leftLetter))
                {
                    number = number / (leftLetter % 32);
                }
                else if (char.IsLower(leftLetter))
                {
                    number = number * (leftLetter % 32);
                }

                if (char.IsUpper(rightLetter))
                {
                    number = number - (rightLetter % 32);
                }
                else if (char.IsLower(rightLetter))
                {
                    number = number + (rightLetter % 32);
                }
                sum += number;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
