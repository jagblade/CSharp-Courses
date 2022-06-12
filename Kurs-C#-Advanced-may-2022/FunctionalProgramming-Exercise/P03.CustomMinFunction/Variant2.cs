using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    internal class Variant2

    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //приема списък -> печатаме най-малкото число в списъка
            Func<List<int>, int> getMinElement = list =>
            {
                int min = int.MaxValue;
                foreach (int number in list)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }

                return min;
            };

            Console.WriteLine(getMinElement(numbers));

        }
    }
}