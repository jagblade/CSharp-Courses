using System;
using System.Collections.Generic;
using System.Linq;


namespace P05.BirthdayCelebrations
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthDate> birthDates = new List<IBirthDate>();

            
            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] current = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (current[0] == "Citizen")
                {
                    DateTime bday = DateTime.ParseExact(current[4],"dd/MM/yyyy", null);

                    birthDates.Add(new Citizen(current[1],
                        int.Parse(current[2]),
                        current[3],
                        bday
                        ));
                }
                else if (current[0] == "Pet")
                {
                    DateTime bday = DateTime.ParseExact(current[2], "dd/MM/yyyy", null);
                    birthDates.Add(new Pet(current[1], bday));
                }

                 cmd = Console.ReadLine();
            }

            int year = int.Parse(Console.ReadLine());

            birthDates.
                Where(b => b.BirthDate.Year == year).
                ToList().
                ForEach(b => Console.WriteLine(string.Format($"{b.BirthDate:dd/MM/yyyy}")));

        }
    }
}
