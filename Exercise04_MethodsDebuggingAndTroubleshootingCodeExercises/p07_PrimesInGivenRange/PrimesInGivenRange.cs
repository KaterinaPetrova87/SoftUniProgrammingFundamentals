using System;
using System.Collections.Generic;

namespace p07_PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            string result = string.Join(", ", FindPrimesInRange(startNum, endNum));

            Console.WriteLine(result);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    list.Add(i);
                    list.Remove(0);
                    list.Remove(1);
                }
            }
            return list;
        }
    }
}
