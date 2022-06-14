using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();


            List<int> numbers = new List<int>(); //всички числа от 1 до n
            for (int number = 1; number <= n; number++)
            {
                numbers.Add(number);
            }

            List<int> printNumbers = new List<int>(); //числата, които се делят на всички делители

            foreach (int number in numbers)
            {
                bool isDivisible = true;
                //true -> ако числото се дели на всички делители
                //false -> ако числото не се дели на всички делители

                //ако се дели на всички числа без остатък от dividers
                foreach (int divider in dividers)
                {
                    //приема число -> дали числото се дели на divider
                    Predicate<int> divisible = number => number % divider == 0;
                    //true -> числото се дели на текущия делител
                    //false -> числото не се дели на текущия делител
                    if (!divisible(number)) //number % divider == 0
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    printNumbers.Add(number);

                }
            }

            Console.WriteLine(string.Join(" ", printNumbers));
        }
    }
}