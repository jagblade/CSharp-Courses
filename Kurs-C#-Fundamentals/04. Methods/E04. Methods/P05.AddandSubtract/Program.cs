using System;

namespace P05.AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine((SubtractThird(SumFirstTwo(first,second),third)));

        }

        static int SumFirstTwo(int first, int second)
        {
            return first + second;  
        }

        static int SubtractThird(int sum, int third)
        {
            return sum - third;
        }
    }
}
