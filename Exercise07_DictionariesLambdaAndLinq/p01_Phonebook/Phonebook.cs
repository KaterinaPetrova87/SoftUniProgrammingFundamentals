using System;
using System.Collections.Generic;

namespace p01_Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    string name = command[1];
                    string phone = command[2];
                    phonebook[name] = phone;
                }
                else if (command[0] == "S")
                {
                    string name = command[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
