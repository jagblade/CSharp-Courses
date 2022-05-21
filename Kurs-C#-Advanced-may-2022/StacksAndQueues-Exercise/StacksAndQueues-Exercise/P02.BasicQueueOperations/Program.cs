using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvancedMay2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()    //"5 2 13"
                            .Split(' ')           //["5", "2", "13"]
                            .Select(x => int.Parse(x)) //[5, 2, 13]
                            .ToArray();
            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            List<int> numbersList = Console.ReadLine() // "1 13 45 32 4"
                                    .Split(' ')        //["1", "13", "45", "32", "4"]
                                    .Select(x => int.Parse(x)) //[1, 13, 45, 32, 4]
                                    .ToList();          // {1, 13, 45, 32, 4}

            Queue<int> queue = new Queue<int>(); //нов празен стек

            //N -> броят на елементите enqueue
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbersList[i]);
            }

            //S -> броят на елементите dequeue
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            //X -> потърсим в опашка
            if (queue.Count == 0) //празна опашка 
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min()); //най-малкия елемент в опашка
            }

        }
    }
}
