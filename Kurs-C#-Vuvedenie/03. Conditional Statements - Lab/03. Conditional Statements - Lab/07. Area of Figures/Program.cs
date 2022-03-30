using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double result = 0;

            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());

                result = sideA * sideA;

            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                result = sideA * sideB;
            }
            else if (figure == "circle")
            {
                double rad = double.Parse(Console.ReadLine());

                result = Math.PI * rad * rad;
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double  hightA = double.Parse(Console.ReadLine());

                result = (sideA * hightA) / 2;
            }

            Console.WriteLine($"{result:F3}");
        }
    }
}
