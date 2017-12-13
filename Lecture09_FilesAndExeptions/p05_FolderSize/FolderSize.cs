using System;
using System.IO;

namespace p05_FolderSize
{
    public class FolderSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fInfo = new FileInfo(file);
                sum += fInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
