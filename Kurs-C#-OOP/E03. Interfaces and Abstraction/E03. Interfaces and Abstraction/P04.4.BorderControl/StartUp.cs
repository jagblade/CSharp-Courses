using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._4.BorderControl
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> passengers = new List<IIdentifiable>();

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] current = cmd.Split(' ');

                if (current.Length == 2)
                {
                    passengers.Add(new Robot(current[0], current[1]));
                }
                else if(current.Length == 3)
                {
                    passengers.Add(new Citizen(current[0], int.Parse(current[1]), current[2]));
                }

                cmd = Console.ReadLine();
            }

            string fakeIdsLastDigits = Console.ReadLine();
               
            passengers.
                Where(p => p.Id.EndsWith(fakeIdsLastDigits)).
                ToList().
                ForEach(p => Console.WriteLine(p.Id));
        }
    }
}
