using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int ticket = 0;

            switch (day)
            {
                case "Monday":
                    ticket = 12;
                    break;
                case "Tuesday":
                    ticket = 12;
                    break;
                case "Wednesday":
                    ticket = 14;
                    break;
                case "Thursday":
                    ticket = 14;
                    break;
                case "Friday":
                    ticket = 12;
                    break;
                case "Saturday":
                    ticket = 16;
                    break;
                case "Sunday":
                    ticket = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(ticket);
        }
    }
}
