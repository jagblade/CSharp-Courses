using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int year = 1;

            double totalSum = 0;
            int fail = 0;

            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    fail++;
                    if (fail == 2)
                    {

                        break;
                    }
                    continue;
                   
                }

                totalSum += grade;
                year++;
            }

            double avrGrade = totalSum / 12;

            if (fail == 2)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {avrGrade:f2}");
            }

        }
    }
}
