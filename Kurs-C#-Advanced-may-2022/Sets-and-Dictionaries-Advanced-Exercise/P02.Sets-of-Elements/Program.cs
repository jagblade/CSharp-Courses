using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n -> дължина на сет1
            //m -> дължина на сет2
            //"3 4".Split(' ') -> ["3", "4"]
            string input = Console.ReadLine(); //"4 3"
            int n = int.Parse(input.Split(' ')[0]);
            int m = int.Parse(input.Split(' ')[1]);

            HashSet<int> firstSet = new HashSet<int>(); //сет 1
            for (int i = 1; i <= n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> secondSet = new HashSet<int>(); //сет 2
            for (int i = 1; i <= m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            //firstSet -> {1, 3, 5, 7}
            //secondSet -> {3, 4, 5}
            firstSet.IntersectWith(secondSet); //в първия сет остават само елементи, които ги има във втория
            //firstSet -> {3, 5}
            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
