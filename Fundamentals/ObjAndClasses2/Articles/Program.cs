using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine()
                .Split(", ");

            Article article = new Article
            {
                Title = articleData[0],
                Content = articleData[1],
                Author = articleData[2]
            };

            int changes = int.Parse(Console.ReadLine());

            for (int i = 0; i < changes; i++)
            {
                string[] commandParts = Console.ReadLine()
                    .Split(": ");
                string command = commandParts[0];
                string change = commandParts[1];

                if (command == "Edit")
                {
                    article.Edit(change);
                }
                else if (command == "Rename")
                {
                    article.Rename(change);

                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(change);
                }
            }
            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
