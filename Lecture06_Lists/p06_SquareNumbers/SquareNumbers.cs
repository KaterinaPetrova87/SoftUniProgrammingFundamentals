using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            List<double> squareNumbers = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)(Math.Sqrt(numbers[i])))
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            squareNumbers.Sort();
            squareNumbers.Reverse();

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
