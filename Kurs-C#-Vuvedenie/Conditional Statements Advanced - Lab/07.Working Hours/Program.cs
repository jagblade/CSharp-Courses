using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else if (hour>=10 && hour<=18)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}
