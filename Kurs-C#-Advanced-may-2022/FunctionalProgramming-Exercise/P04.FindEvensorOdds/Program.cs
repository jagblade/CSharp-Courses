using System;
using System.Collections.Generic;

namespace _4._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"10 20".Split -> ["10", "20"]
            string input = Console.ReadLine();
            int startNumber = int.Parse(input.Split()[0]);
            int endNumber = int.Parse(input.Split()[1]);

            List<int> numbers = new List<int>(); //числата в диапазона от startNumber до endNumber
            for (int number = startNumber; number <= endNumber; number++)
            {
                numbers.Add(number);
            }

            Predicate<int> predicate = null;
            //true -> числото е четно
            //false -> числото е нечетно

            //"odd" или "even"
            string type = Console.ReadLine();
            if (type == "even")
            {
                //true за четни, false за нечетни
                predicate = number => number % 2 == 0;
            }
            else if (type == "odd")
            {
                //true за нечетни, false за четни
                predicate = number => number % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
            //списък с числата, за които predicate е true

        }
    }
}