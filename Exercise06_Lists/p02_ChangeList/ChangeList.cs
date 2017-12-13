using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_ChangeList
{
    public class ChangeList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    numbers.RemoveAll(e => e == element);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine().Split().ToArray();
            }

            if (command[0] == "Odd")
            {
                foreach (var num in numbers)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            else if (command[0] == "Even")
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}

