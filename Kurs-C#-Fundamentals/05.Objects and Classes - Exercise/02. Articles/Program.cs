using System;

namespace _02._Articles
{

    class Article
    {
        public Article()
        {
            
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] current = Console.ReadLine().Split(", ");

           Article article = new Article();
            article.Title = current[0];
            article.Content = current[1];
            article.Author = current[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    article.Content = command[1];
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.Author = command[1];
                }
                else if(command[0] == "Rename")
                {
                    article.Title = command[1];
                }

            }

            Console.WriteLine(article.ToString()); 

        }
    }
}
