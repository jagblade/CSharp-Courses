using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //PRINT: получаваме списък -> принтираме списъка
            Action<List<int>> print = list => Console.WriteLine(String.Join(" ", list));

            Func<List<int>, List<int>> operation = null; //обща функция за add, multiply, subtract

            string command = Console.ReadLine();

            while (command != "end")
            {   //command = "add" или "multiply" или "subtract" или "print"
                switch (command)
                {
                    case "add":
                        operation = list => list.Select(number => number += 1).ToList();
                        numbers = operation(numbers);
                        break;
                    case "multiply":
                        operation = list => list.Select(number => number *= 2).ToList();
                        numbers = operation(numbers);
                        break;
                    case "subtract":
                        operation = list => list.Select(number => number -= 1).ToList();
                        numbers = operation(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}