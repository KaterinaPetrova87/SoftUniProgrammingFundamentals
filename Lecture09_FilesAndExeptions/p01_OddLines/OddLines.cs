using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace p01_OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var file = "TextFile1.txt";
            var lines = File.ReadAllLines(file);

            var oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }

            File.WriteAllLines("result.txt", oddLines);
        }
    }
}
