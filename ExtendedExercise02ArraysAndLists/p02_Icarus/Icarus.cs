using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Icarus
{
    public class Icarus
    {
        public static void Main()
        {
            List<int> plane = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int startingIndex = int.Parse(Console.ReadLine());
            int damage = 1;
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Supernova")
            {
                string direction = command[0];
                int steps = int.Parse(command[1]);

                if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        startingIndex--;
                        if (startingIndex < 0)
                        {
                            startingIndex = plane.Count - 1;
                            damage++;
                        }
                        plane[startingIndex] -= damage;
                    }
                }
                else if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        startingIndex++;
                        if (startingIndex > plane.Count - 1)
                        {
                            startingIndex = 0;
                            damage++;
                        }
                        plane[startingIndex] -= damage;
                    }
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
