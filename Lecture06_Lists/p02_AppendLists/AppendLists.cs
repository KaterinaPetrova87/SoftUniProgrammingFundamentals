using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            List<string> result = new List<string>();

            foreach (string item in input)
            {
                List<string> numbers = item.Split(' ').ToList();

                foreach (string number in numbers)
                {
                    if (number != "")
                    {
                        result.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
