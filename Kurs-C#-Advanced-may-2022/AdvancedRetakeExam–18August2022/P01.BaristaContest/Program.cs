using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coffeeInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] milkInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> coffee = new Queue<int>(coffeeInput);
            Stack<int> milk = new Stack<int>(milkInput);

            SortedDictionary<string, int> drinks = new SortedDictionary<string, int>
            {
                { "Cortado", 0 },
                {"Espresso" , 0 },
                { "Capuccino", 0 },
                { "Americano",   0 },
                { "Latte",   0 }
            };

            while (coffee.Any() && milk.Any())
            {
                int sum = coffee.Peek() + milk.Peek();

                if (sum == 50)
                {
                    //{ "Cortado", 50 },
                    coffee.Dequeue();
                    milk.Pop();
                    drinks["Cortado"]++;
                }
                else if (sum == 75)
                {
                    //    { "Espresso" , 75 },
                    coffee.Dequeue();
                    milk.Pop();
                    drinks["Espresso"]++;
                }
                else if (sum == 100)
                {
                    //    { "Capuccino", 100 },
                    coffee.Dequeue();
                    milk.Pop();
                    drinks["Capuccino"]++;
                }
                else if (sum == 150)
                {
                    //    { "Americano",   150 },
                    coffee.Dequeue();
                    milk.Pop();
                    drinks["Americano"]++;
                }
                else if (sum == 200)
                {
                    //    { "Latte",   200 }
                    coffee.Dequeue();
                    milk.Pop();
                    drinks["Latte"]++;
                }
                else
                {
                    coffee.Dequeue();
                    int milkLeft = milk.Peek() - 5;
                    milk.Pop();
                    milk.Push(milkLeft);
                }





            }

            if (coffee.Count == 0 && milk.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");     
            }

            if (coffee.Any())
            {
                Console.WriteLine($"Coffee left: " + string.Join(", ", coffee));
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }
            if (milk.Any())
            {
                Console.WriteLine($"Milk left: " + string.Join(", ", milk));
            }
            else
            {
                Console.WriteLine("Milk left: none");
            }

            foreach (var drink in drinks.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (drink.Value > 0)
                {
                    Console.WriteLine($"{drink.Key}: {drink.Value}");
                }
            }
        }
    }
}
