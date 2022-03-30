using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 1; i <= n; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum = sum + num; 
            }

            double diff = sum - max; 

            if (diff == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(diff)}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - diff)}");
            }
        }
    }
}
