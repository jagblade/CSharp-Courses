using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (current > n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
