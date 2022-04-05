using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Article
    {
        public Article()
        {

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> allArticles = new List<Article>();



            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split(", ");

                Article article = new Article();
                article.Title = current[0];
                article.Content = current[1];
                article.Author = current[2];

                allArticles.Add(article);
            }

            string searched = Console.ReadLine();

            foreach (var articles in allArticles)
            {
                Console.WriteLine(articles.ToString());
            }


        }
    }
}
