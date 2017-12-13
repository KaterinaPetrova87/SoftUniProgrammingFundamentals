using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int k = numbers.Count / 4;

            List<int> leftNums = numbers.Take(k).Reverse().ToList();
            List<int> middleNums = numbers.Skip(k).Take(2 * k).ToList();
            List<int> rightNums = numbers.Skip(3 * k).Take(k).Reverse().ToList();
            List<int> leftAndRightNums = leftNums.Concat(rightNums).ToList();

            List<int> sum = leftAndRightNums.Select((n, index) => n + middleNums[index]).ToList();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

