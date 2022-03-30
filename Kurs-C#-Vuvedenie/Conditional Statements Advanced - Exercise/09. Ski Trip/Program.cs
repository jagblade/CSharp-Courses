using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double total = 0;

            if (roomType == "room for one person")
            {
                double price = 18;

                total = price * (days - 1);

                if (evaluation == "positive")
                {
                    total = total + (total * 0.25);
                }
                else if (evaluation == "negative")
                {
                    total = total - (total * 0.10);
                }

                Console.WriteLine($"{total:f2}");
            }
            else if (roomType == "apartment")
            {
                double price = 25;

                total = price * (days - 1);

                if (days < 10)
                {
                    total = total - (total * 0.30);
                }
                else if (days >=10 && days <=15 )
                {
                    total = total - (total * 0.35);
                }
                else if (days > 15)
                {
                    total = total - (total * 0.50);
                }

                if (evaluation == "positive")
                {
                    total = total + (total * 0.25);
                }
                else if (evaluation == "negative")
                {
                    total = total - (total * 0.10);
                }

                Console.WriteLine($"{total:f2}");
            }
            else if (roomType == "president apartment")
            {
                double price = 35;

                total = price * (days - 1);

                if (days < 10)
                {
                    total = total - (total * 0.10);
                }
                else if (days >= 10 && days <= 15)
                {
                    total = total - (total * 0.15);
                }
                else if (days > 15)
                {
                    total = total - (total * 0.20);
                }

                if (evaluation == "positive")
                {
                    total = total + (total * 0.25);
                }
                else if (evaluation == "negative")
                {
                    total = total - (total * 0.10);
                }

                Console.WriteLine($"{total:f2}");
            }

        }
    }
}
