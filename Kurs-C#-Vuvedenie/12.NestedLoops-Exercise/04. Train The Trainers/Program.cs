using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string presentation = Console.ReadLine();
            int countStudent = 0;
            double grade = 0;

            while (presentation != "Finish")
            {
                double personalGrade = 0;
                countStudent++;

                for (int i = 1; i <= n; i++)
                {
                    personalGrade += double.Parse(Console.ReadLine());
                }

                personalGrade = personalGrade / n;
                grade += personalGrade;

                Console.WriteLine($"{presentation} - {personalGrade:F2}.");
                presentation = Console.ReadLine();
            }

            grade = grade / countStudent;
            Console.WriteLine($"Student's final assessment is {grade:F2}.");
        }
    }
}
