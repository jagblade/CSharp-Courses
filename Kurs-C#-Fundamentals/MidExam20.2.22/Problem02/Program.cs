using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine().Split(">>", StringSplitOptions.RemoveEmptyEntries).ToList();

            decimal totalSum = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                string[] cmd = cars[i].
                    Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carType = cmd[0];
                int carYears = int.Parse(cmd[1]);
                int carMiles = int.Parse(cmd[2]);
                decimal currentCarTax = 0;
                

                if (carType == "family")
                {
                    currentCarTax = (carMiles / 3000) * 12 + (50 - carYears * 5);
                     
                }
                else if (carType == "heavyDuty")
                {
                    currentCarTax = (carMiles / 9000) * 14 + (80 - carYears * 8);
                }
                else if (carType == "sports")
                {
                    currentCarTax = (carMiles / 2000) * 18 + (100 - carYears * 9);
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                    continue;
                }

                Console.WriteLine($"A {carType} car will pay {currentCarTax:f2} euros in taxes.");

                totalSum += currentCarTax;

            }

            Console.WriteLine($"The National Revenue Agency will collect {totalSum:f2} euros in taxes.");
        }
    }
}
