using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();  

            while (input != "end")
            {
                string[] line = input.Split();

                string action = line[0];

                if (action == "Add")
                {
                    wagons.Add(int.Parse(line[1]));
                }
                else
                {

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int inWagon = wagons[i] + int.Parse(action);
                        if ( inWagon <= maxCapacity )
                        {
                            wagons[i] = inWagon;
                            break;
                        }
                        else
                        {
                            //No room in cart
                            continue;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",wagons));
        }
    }
}
