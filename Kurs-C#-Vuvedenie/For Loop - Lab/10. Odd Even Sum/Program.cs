using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int s = int.Parse(Console.ReadLine());
                    odd += s;
                }
                else
                {
                    int s = int.Parse(Console.ReadLine());
                    even += s;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", even);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(even - odd));
            }
        }
    }
}
