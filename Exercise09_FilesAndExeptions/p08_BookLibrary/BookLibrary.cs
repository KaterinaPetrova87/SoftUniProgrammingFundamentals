using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p09_BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("../../input.txt");

            var books = new List<Book>();

            foreach (var line in lines)
            {
                var tokens = line.Split();
                var title = tokens[0];
                var author = tokens[1];
                var publisher = tokens[2];
                var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = tokens[4];
                var price = decimal.Parse(tokens[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    ISBN = isbn,
                    Price = price
                };

                books.Add(book);

                var grouped = books.GroupBy(a => a.Author);
                var libraries = grouped.Select(group => new Library()
                {
                    Name = group.Key,
                    Books = group.ToList()
                })
                .OrderByDescending(library => library.Books.Sum(a => a.Price))
                .ThenBy(a => a.Name)
                .ToArray();

                var output = new List<string>();
                foreach (var library in libraries)
                {
                    output.Add( $"{library.Name} -> {library.Books.Sum(a => a.Price)}");
                    File.WriteAllLines("../../output.txt", output);
                }
            }
        }
    }
}

