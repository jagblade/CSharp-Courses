using System;

namespace _01.CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
       
            double pFat = (double.Parse(Console.ReadLine())/100);
            double pProtein = (double.Parse(Console.ReadLine())/100);
            double pCarbo = (double.Parse(Console.ReadLine())/100);

            double totalCal = double.Parse(Console.ReadLine());
            double pWater = (double.Parse(Console.ReadLine())/100);

            double fat = (totalCal * pFat) / 9;
            double protein = (totalCal * pProtein) / 4;
            double carbo = (totalCal * pCarbo) / 4;

            double totalFood = fat + protein + carbo;

            double calPerGram = totalCal / totalFood;

            double calories = calPerGram * (1 - (pWater));

            Console.WriteLine($"{calories:f4}");
        }
    }
}
