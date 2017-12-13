using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p02_IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../input.txt");
            File.Delete("../../output.txt");

            foreach (var line in input)
            {
                foreach (var item in line.ToString())
                {
                    if (item - 'a' >= 0)
                    {
                        var result = $"{item} -> {item - 'a'}";
                        File.AppendAllText("../../output.txt", result + Environment.NewLine);
                    }
                }
            }
        }
    }
}

