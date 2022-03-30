using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = 0;
            int minNum = 0;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());

               if (i == 1) minNum = maxNum = input;
                else
                {
                    if (minNum > input) minNum = input;
                    if (maxNum < input) maxNum = input;
                } 

            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");

        }
    }
}
