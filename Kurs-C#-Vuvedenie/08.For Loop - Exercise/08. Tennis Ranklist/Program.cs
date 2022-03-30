using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int seasonTotal = 0;
            double wins = 0;

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                if (current == "W")
                {
                    points += 2000;
                    seasonTotal += 2000;
                    wins++;
                }
                else if (current == "F")
                {
                    points += 1200;
                    seasonTotal += 1200;
                }
                else if (current == "SF")
                {
                    points += 720;
                    seasonTotal += 720;
                }
            }

            double averagePoints = seasonTotal / n;
            double pWins = wins / n * 100;

            Console.WriteLine("Final points: {0}", points);
            Console.WriteLine("Average points: {0}", Math.Floor(averagePoints));
            Console.WriteLine($"{pWins:f2}%");
        }
    }
}
