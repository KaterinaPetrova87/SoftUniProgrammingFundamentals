using System;
using System.Linq;

namespace p06_FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;

            int[] left = numbers.Take(k).Reverse().ToArray();
            int[] second = numbers.Skip(k).Take(2 * k).ToArray();
            int[] right = numbers.Skip(3 * k).Reverse().ToArray();
            int[] first = left.Concat(right).ToArray();

            int[] sum = first.Select((element, index) => element + second[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
