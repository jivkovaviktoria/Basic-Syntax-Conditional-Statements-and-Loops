using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split(", "); 

            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] lines = command.Split(": ");

                if (lines[0] == "Rename")
                {
                    article.Rename(lines[1]);
                }
                else if (lines[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(lines[1]);
                }
                else if (lines[0] == "Edit")
                {
                    article.Edit(lines[1]);
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;
    }
}
