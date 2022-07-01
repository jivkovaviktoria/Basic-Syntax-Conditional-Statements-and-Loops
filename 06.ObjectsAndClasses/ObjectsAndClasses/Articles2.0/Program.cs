using System;
using System.Collections.Generic;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticles; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                Article article = new Article(tokens[0], tokens[1], tokens[2]);
                articles.Add(article);

            }

            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
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

    }
}
