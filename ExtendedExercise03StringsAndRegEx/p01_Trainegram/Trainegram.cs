using System;
using System.Text.RegularExpressions;

namespace p01_Trainegram
{
    public class Trainegram
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[[^a-zA-Z0-9]*\]\.)+(\.\[[A-Za-z0-9]*\]\.)*$";
            Regex regex = new Regex(pattern);

            while (input != "Traincode!")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine(input);
                }
               
                input = Console.ReadLine();
            }
        }
    }
}
