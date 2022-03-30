using System;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            int totalPassengers = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                totalPassengers += wagons[i];
            }

            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(totalPassengers);

        }
    }
}
