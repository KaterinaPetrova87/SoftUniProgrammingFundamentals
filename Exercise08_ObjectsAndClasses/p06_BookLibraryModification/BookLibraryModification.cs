using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p06_BookLibraryModification
{
    public class BookLibraryModification
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
                    ReleaseDate = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                });
            }
            Library library = new Library { Name = "Library", Books = books };

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var dictionary = new Dictionary<string, DateTime>();

            foreach (Book book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(date) > 0)
                {
                    dictionary.Add(book.Title, book.ReleaseDate);
                }
            }

            foreach (var title in dictionary.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{title.Key} -> {title.Value:dd.MM.yyyy}");
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
