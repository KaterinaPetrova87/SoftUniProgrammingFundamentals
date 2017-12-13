using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_CameraView
{
    public class CameraView
    {
        public static void Main()
        {
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipElements = firstInput[0];
            int takeElements = firstInput[1];

            string input = Console.ReadLine();

            Regex regex = new Regex(@"\|<(\w{" + skipElements + @"})(\w{0," + takeElements + @"})");

            MatchCollection solution = regex.Matches(input);

            List<string> pictures = new List<string>();

            foreach (Match camera in solution)
            {
                pictures.Add(camera.Groups[2].Value.ToString());
            }

            Console.WriteLine(string.Join(", ", pictures));
        }
    }
}
