using System;

namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            double result = CalculateFact(firstInput)/CalculateFact(secondInput);

            Console.WriteLine($"{result:F2}");
        } 

        private static double CalculateFact(double input)
        {
            double result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
