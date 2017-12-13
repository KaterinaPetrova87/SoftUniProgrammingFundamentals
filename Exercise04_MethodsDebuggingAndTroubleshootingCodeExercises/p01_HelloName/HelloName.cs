using System;

namespace p01_HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintGreetingByName(name);
        }

        public static void PrintGreetingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
