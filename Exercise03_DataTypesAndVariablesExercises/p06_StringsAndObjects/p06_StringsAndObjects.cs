using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_StringsAndObjects
{
    class p06_StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object concatenatedWords = firstWord + " " + secondWord;
            string concatenate = Convert.ToString(concatenatedWords);
            //string concatenate = (string)concatenatedWords

            Console.WriteLine(concatenate);
        }
    }
}
