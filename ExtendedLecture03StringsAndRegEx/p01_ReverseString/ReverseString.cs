using System;

namespace p01_ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var strArray = input.ToCharArray();
            Array.Reverse(strArray);
            input = new string(strArray);

            Console.WriteLine(input);
        }
    }
}
