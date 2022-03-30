using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();

            int badGradeCounter = 0;
            int taskCounter = 0;
            double totalGrades = 0;
            string lastProblem = string.Empty;


            while (task != "Enough")
            {
                lastProblem = task;
                double grade = double.Parse(Console.ReadLine());

                taskCounter++;
                totalGrades += grade;

                if (grade <= 4.00)
                {
                    badGradeCounter++;
                }

                if (badGradeCounter == badGrade)
                {
                    Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
                    return;
                }
                
                task = Console.ReadLine();
            }

            Console.WriteLine($"Average score: {totalGrades/taskCounter:f2}");
            Console.WriteLine($"Number of problems: {taskCounter}");
            Console.WriteLine($"Last problem: {lastProblem}");
            
        }
    }
}

