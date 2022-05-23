using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades
{
    static void Main()
    {
        var studentGrades = new Dictionary<string, List<double>>();
        int gradesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < gradesCount; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            string name = line[0];
            double grade = double.Parse(line[1]);
            if (!studentGrades.ContainsKey(name))
                studentGrades.Add(name, new List<double>());
            studentGrades[name].Add(grade);
        }

        foreach (var name in studentGrades.Keys)
        {
            List<double> grades = studentGrades[name];
            string gradesStr = string.Join(" ",
                grades.Select(g => g.ToString("f2")));
            double avg = grades.Average();
            Console.WriteLine($"{name} -> {gradesStr} (avg: {avg:f2})");
        }
    }
}