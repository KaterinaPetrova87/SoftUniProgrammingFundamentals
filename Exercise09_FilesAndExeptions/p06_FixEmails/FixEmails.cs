using System;
using System.IO;

namespace p06_FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("../../input.txt");

            File.Delete("../../output.txt");

            for (int i = 0; i < lines.Length-1; i+=2)
            {
                var name = lines[i];
                var email = lines[i + 1];

                if(email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }

                var output = $"{name} -> {email}" + Environment.NewLine;
                File.AppendAllText("../../output.txt", output);
            }
        }
    }
}
