using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                 .Split()
                 .ToList();
            int sum = 0;

            foreach (string item in input)
            {
                char[] array = item.ToCharArray();
                array = array.Reverse().ToArray();
                int num = int.Parse(new string(array));
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
