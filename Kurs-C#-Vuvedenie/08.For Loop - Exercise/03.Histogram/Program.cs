using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0; //< 200 (група на числа м/у 0 и 199 вкл.)
            double p2 = 0; //<400 (<=399) (група на числа м/у 200 и 399 вкл.)
            double p3 = 0; //<600 (група на числа м/у 400 и 599 вкл.)
            double p4 = 0; //<800 (група на числа м/у 600 и 799 вкл.)
            double p5 = 0; //≥ 800 (група на числа по-големи или равни на 800)

            //for (int i = 0; i < n; i++)
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");

        }
    }
}
