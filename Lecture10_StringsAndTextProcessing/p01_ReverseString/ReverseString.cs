using System;

namespace p01_ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var array = text.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(new string(array));
        }
    }
}
