using System;

namespace _04._Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int typePCs = int.Parse(Console.ReadLine());

            double sales = 0;
            double avrRatingTotal = 0;

            for (int i = 0; i < typePCs; i++)
            {
                int code = int.Parse(Console.ReadLine());
                int rating = code % 10;
                double currentSales = code / 10;

                if (rating == 2)
                {
                    avrRatingTotal += 2;
                }
                else if (rating == 3)
                {
                    avrRatingTotal += 3;
                    sales += currentSales * 0.5;
                }
                else if (rating == 4)
                {
                    avrRatingTotal += 4;
                    sales += currentSales * 0.7;
                }
                else if (rating == 5)
                {
                    avrRatingTotal += 5;
                    sales += currentSales * 0.85;
                }
                else if (rating == 6)
                {
                    avrRatingTotal += 6;
                    sales += currentSales;
                }
            }

            double avrRating = avrRatingTotal / typePCs;

            Console.WriteLine($"{sales:f2}");
            Console.WriteLine($"{avrRating:f2}");

        }
    }
}
