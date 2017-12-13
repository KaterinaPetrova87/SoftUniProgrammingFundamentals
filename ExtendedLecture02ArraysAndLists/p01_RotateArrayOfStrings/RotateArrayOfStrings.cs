using System;

namespace p01_RotateArrayOfStrings
{
    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                 .Split();

            string temp = array[array.Length - 1];

            for (int i = array.Length-1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
