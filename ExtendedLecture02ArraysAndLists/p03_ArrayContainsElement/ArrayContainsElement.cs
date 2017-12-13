using System;
using System.Linq;

namespace p03_ArrayContainsElement
{
    public class ArrayContainsElement
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            bool isFind = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(n == numbers[i])
                {
                    isFind = true;
                    break;
                }
            }
            if (isFind)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
