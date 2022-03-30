using System;

namespace _04.DearOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysWithoutSanta = int.Parse(Console.ReadLine());
            int leftoverFoodKg = int.Parse(Console.ReadLine());
            double foodFirstDeer = double.Parse(Console.ReadLine());
            double foodSecondDeer = double.Parse(Console.ReadLine());
            double foodThirdDeer = double.Parse(Console.ReadLine());

            foodFirstDeer = daysWithoutSanta * foodFirstDeer;
            foodSecondDeer = daysWithoutSanta * foodSecondDeer;
            foodThirdDeer = daysWithoutSanta * foodThirdDeer;
            double remainKg = 0;
            double lackingKg = 0;
            double totalFood = foodFirstDeer + foodSecondDeer + foodThirdDeer;

            if (totalFood < leftoverFoodKg)
            {
                remainKg = leftoverFoodKg - totalFood;
                Console.WriteLine($"{Math.Floor(remainKg)} kilos of food left.");
            }
            else
            {
                lackingKg = totalFood - leftoverFoodKg;
                Console.WriteLine($"{Math.Abs(Math.Ceiling(lackingKg))} more kilos of food are needed.");
            }
        }
    }
}
