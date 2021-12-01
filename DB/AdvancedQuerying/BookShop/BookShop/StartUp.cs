namespace BookShop
{
    using System;
    using Data;
    using System.Linq;
    using System.Text;
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            Console.WriteLine(RemoveBooks(db)); 
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {

            var books = context
             .Books
             .ToArray()
             .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
             .OrderBy(b => b.Title)
             .ToArray();

            var sb = new StringBuilder();
            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title}");
            }

            return sb.ToString();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context
                .Books
                .ToArray()
                .Where(b => b.EditionType.ToString() == "Gold" && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var t in books)
            {
                sb.AppendLine($"{t}");
            }
            return sb.ToString();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context
                .Books
                .ToArray()
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title} - ${b.Price:f2}");
            }
            return sb.ToString();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var titles = context
                .Books
                .ToArray()
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(c => c.ToLower()).ToArray();

            var books = context
                 .Books
                 .Where(b => b.BookCategories.Select(bc => bc.Category.Name.ToLower()).Intersect(categories).Any())
                 .Select(b => b.Title)
                 .OrderBy(b => b)
                 .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var books = context
                .Books
                .ToArray()
                .OrderByDescending(b => b.ReleaseDate)
                .Where(b => DateTime.Compare(b.ReleaseDate.Value, parsedDate) < 0)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                })
                .ToArray();

            var sb = new StringBuilder();
            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price:f2}");
            }

            return sb.ToString();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context
                .Authors
                .ToArray()
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .OrderBy(a => a.FullName)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var a in authors)
            {
                sb.AppendLine(a.FullName);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context
                .Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context
               .Books
               .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
               .OrderBy(b => b.BookId)
               .Select(b => new
               {
                   b.Title,
                   AuthorFirstName = b.Author.FirstName,
                   AuthorLastName =b.Author.LastName
               })
               .ToArray();

            var sb = new StringBuilder();
            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title} ({b.AuthorFirstName} {b.AuthorLastName})");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var count = context
                .Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return count;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorCopies = context
                .Authors
                .Include(b => b.Books)
                .OrderByDescending(a=> a.Books.Sum(b => b.Copies))
                .Select(a => new
                {
                    AuthorName = $"{a.FirstName} {a.LastName}",
                    TotalCopies = a.Books.Sum(b => b.Copies)
                })
                .ToArray();

            var sb = new StringBuilder();
            foreach (var a in authorCopies)
            {
                sb.AppendLine($"{a.AuthorName} - {a.TotalCopies}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context
                .Categories
                .Include(cb => cb.CategoryBooks)
                .Select(c => new
                {
                    TotalProfit = c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price),
                    CategoryName = c.Name
                })
                .OrderByDescending(c=> c.TotalProfit)
                .ThenBy(c => c.CategoryName)
                .ToArray();


            var sb = new StringBuilder();
            foreach (var c in categories)
            {
                sb.AppendLine($"{c.CategoryName} ${c.TotalProfit:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks
                        .Select(bc => new
                        {
                            Title = bc.Book.Title,
                            ReleaseDate = bc.Book.ReleaseDate
                        })
                        .OrderByDescending(bc => bc.ReleaseDate)
                        .Take(3)
                })
                .OrderBy(c => c.CategoryName)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.CategoryName}");
                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }

            return sb.ToString().Trim();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToArray();
            foreach (var book in books)
            {
                book.Price += 5;
            }
            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksDeleted = context
                .Books
                .Where(b => b.Copies < 4200)
                .ToArray();

            context.Books.RemoveRange(booksDeleted);
            context.SaveChanges();

            return booksDeleted.Length;
        }
    }
}
