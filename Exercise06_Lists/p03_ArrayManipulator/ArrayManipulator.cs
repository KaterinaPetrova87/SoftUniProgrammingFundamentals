using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int element = int.Parse(tokens[2]);

                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(tokens[1]);
                        List<int> elementsToAdd = tokens.Skip(2).Select(int.Parse).ToList();

                        numbers.InsertRange(index, elementsToAdd);
                        break;
                    case "contains":
                        element = int.Parse(tokens[1]);

                        Console.WriteLine(numbers.IndexOf(element));
                        break;
                    case "remove":
                        index = int.Parse(tokens[1]);

                        numbers.RemoveAt(index);
                        break;
                    case "shift":   //shift to left
                        int positions = int.Parse(tokens[1]);

                        for (int i = 0; i < positions; i++)
                        {
                            int lastElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        List<int> newList = new List<int>();

                        for (int i = 0; i < numbers.Count - 1; i += 2)
                        {
                            newList.Add(numbers[i] + numbers[i + 1]);
                        }

                        if (numbers.Count % 2 == 1)
                        {
                            newList.Add(numbers[numbers.Count - 1]);
                        }

                        numbers = newList;
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
