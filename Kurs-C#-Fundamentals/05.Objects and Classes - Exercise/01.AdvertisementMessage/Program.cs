using System;
using System.Text;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(phrases.Length);
                string phrase = phrases[index];

                index = rnd.Next(events.Length);
                string currentEvent = events[index];

                index = rnd.Next(authors.Length);
                string author = authors[index];

                index = rnd.Next(city.Length); 
                string currentCity = city[index];

                Console.WriteLine();

                StringBuilder sb = new StringBuilder();

                sb.Append($"{phrase}");
                sb.Append($"{currentEvent}");
                sb.Append($"{author}");
                sb.Append($"{currentCity}");

                Console.WriteLine(sb);
            }
        }
    }
}
