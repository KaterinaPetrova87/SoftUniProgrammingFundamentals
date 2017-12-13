using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_FixEmails
{
    public class FixEmails
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emailBook = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (!emailBook.ContainsKey(name))
                {
                    emailBook.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var pair in emailBook.Where(p => !(p.Value.EndsWith(".uk") || p.Value.EndsWith(".us"))))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
