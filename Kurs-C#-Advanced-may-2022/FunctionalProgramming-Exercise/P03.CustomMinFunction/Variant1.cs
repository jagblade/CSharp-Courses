using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    internal class Variant1
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //приема списък -> връща най-малкото число в списъка
            Func<List<int>, int> getMinElement = list => list.Min();

            Console.WriteLine(getMinElement(numbers));

        }
    }
}

