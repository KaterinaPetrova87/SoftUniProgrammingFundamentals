using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p05_BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                books.Add(new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                });
            }
            Library library = new Library { Name = "Library", Books = books };
            var dictionary = new Dictionary<string, double>();

            foreach (Book book in library.Books)
            {
                if (!dictionary.ContainsKey(book.Author))
                {
                    dictionary[book.Author] = 0;
                }
                dictionary[book.Author] += book.Price;
            }

            foreach (var author in dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value}");
            }
        }

        public class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public double Price { get; set; }
        }
    }
}

