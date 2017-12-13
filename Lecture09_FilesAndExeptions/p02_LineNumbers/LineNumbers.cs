using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace p02_LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("../../input.txt");

            var result = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                result.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("../../output.txt", result);
         }  
    }
}
