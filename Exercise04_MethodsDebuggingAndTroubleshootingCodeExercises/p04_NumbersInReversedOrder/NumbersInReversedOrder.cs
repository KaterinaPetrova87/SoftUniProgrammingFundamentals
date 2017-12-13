using System;

namespace p04_NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        static void ReverseNumber(string number)
        {
            for (int i = number.Length-1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
    }
}
