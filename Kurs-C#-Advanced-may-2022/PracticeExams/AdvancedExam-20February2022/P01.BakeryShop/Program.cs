using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] waterInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double[] flourInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Queue<double> water = new Queue<double>(waterInput);
            Stack<double> flour = new Stack<double>(flourInput);

            SortedDictionary<string, double> bakedGoods = new SortedDictionary<string, double>()
            {
                {"Baguette", 0 },
                {"Bagel", 0 },
                {"Croissant", 0 },
                {"Muffin", 0 },

            };

            while (water.Any() && flour.Any())
            {
                double currWater = water.Peek();
                double currFlour = flour.Peek();

                double waterContent = (currWater * 100) / (currFlour + currWater);

                if (waterContent == 50)
                {
                    // Croissant
                    water.Dequeue();
                    flour.Pop();
                    bakedGoods["Croissant"]++;
                }
                else if (waterContent == 40 )
                {
                    // Muffin
                    water.Dequeue();
                    flour.Pop();
                    bakedGoods["Muffin"]++;
                }
                else if(waterContent == 30)
                {
                    // Baguette
                    water.Dequeue();
                    flour.Pop();
                    bakedGoods["Baguette"]++;
                }
                else if ( waterContent == 20)
                {
                    //Bagel
                    water.Dequeue();
                    flour.Pop();
                    bakedGoods["Bagel"]++;
                }
                else
                {
                    // Croissant + Flour
                    double flourLeft = flour.Peek() - water.Peek();
                    flour.Pop();
                    water.Dequeue();
                    bakedGoods["Croissant"]++;
                    flour.Push(flourLeft);
                }
            
            }

            foreach (var baked in bakedGoods.OrderByDescending(x => x.Value))
            {
                if (baked.Value > 0)
                {
                    Console.WriteLine($"{baked.Key}: {baked.Value}");
                }
            }

            if (water.Any())
            {
                Console.WriteLine($"Water left: "+string.Join(", ",water));
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (flour.Any())
            {
                Console.WriteLine($"Flour left: "+String.Join(", ",flour));
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
