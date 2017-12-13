using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace p04_MergeFiles
{
    public class MergeFiles
    {
        public static void Main()
        {
            string[] input1 = File.ReadAllLines("FileOne.txt");
            string[] input2 = File.ReadAllLines("FileTwo.txt");

            string[] result = input1.Concat(input2).OrderBy(x => x).ToArray();

            foreach (var item in result)
            {
                File.WriteAllLines("Result.txt", result);
            }
        }
    }
}
