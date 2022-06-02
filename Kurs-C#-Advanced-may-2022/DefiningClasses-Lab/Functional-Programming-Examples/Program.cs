using System;
using System.Collections.Generic;

public delegate int Aggregate(int x, int y);

class Examples
{
    static void Main()
    {
        //Predicate<int> isNegative =
        //    x => x < 0;
        //Predicate<int> isPositive =
        //    x => x > 0;
        //Predicate<int> isOdd =
        //    x => x % 2 == 1;


        //Console.WriteLine(isNegative(5));
        //Console.WriteLine(isNegative(-1));

        //Console.WriteLine(isPositive(5));
        //Console.WriteLine(isPositive(-1));

        //Console.WriteLine(isOdd(5));
        //Console.WriteLine(isOdd(10));

        //var nums = new List<int>{ 5, 10, 15, -5, -1, 20 };

        //Console.WriteLine("Odd: " + String.Join(", ", nums.FindAll(isOdd)));
        //Console.WriteLine("Positives: " + String.Join(", ", nums.FindAll(isPositive)));
        //Console.WriteLine("Negatives: " + String.Join(", ", nums.FindAll(isNegative)));

        //int Operation(int number, Func<int, int> operation)
        //{
        //    return operation(number);
        //}

        //int a = 5;

        //int b = Operation(a, number => number * 5); // 25
        //Console.WriteLine(b);

        //int c = Operation(a, number => number - 3); // 2
        //Console.WriteLine(c);

        //int d = Operation(a, number => number % 2); // 1
        //Console.WriteLine(d);

        long Aggregate(int start, int end, Func<long, long, long> op)
        {
            long result = start;
            for (int i = start + 1; i <= end; i++)
                result = op(result, i);
            return result;
        }

        Console.WriteLine(Aggregate(100, 200, (a, b) => a + b));  // 55
        Console.WriteLine(Aggregate(5, 8, (a, b) => a * b));  // 10! = 3628800
        Console.WriteLine(Aggregate(5, 10, (a, b) => long.Parse(a.ToString() + b)));

    }
}