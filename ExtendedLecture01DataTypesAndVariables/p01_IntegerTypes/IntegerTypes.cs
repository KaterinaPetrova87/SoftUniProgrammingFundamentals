using System;

namespace p01_IntegerTypes
{
    public class IntegerTypes
    {
        public static void Main()
        {
            byte first = byte.Parse(Console.ReadLine());
            uint second = uint.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            long fourth = long.Parse(Console.ReadLine());

            Console.WriteLine($"{first} {second} {third} {fourth}");
        }
    }
}
