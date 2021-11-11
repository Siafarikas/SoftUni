using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ");
                Article article = new Article
                {
                    Title = articleData[0],
                    Content = articleData[1],
                    Author = articleData[2]
                };
                articles.Add(article);
            }
            string command = Console.ReadLine();

            List<Article> sorted = new List<Article>();
            if (command == "title")
            {
                sorted = articles
                    .OrderBy(i => i.Title)
                    .ToList();
            }
            else if (command == "content")
            {
                sorted = articles
                    .OrderBy(i => i.Content)
                    .ToList();
            }
            else if (command == "author")
            {
                sorted = articles
                    .OrderBy(i => i.Author)
                    .ToList();
            }
            foreach (var article in sorted)
            {
                Console.WriteLine(article);
            }
        }
    }
    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}