using System;

namespace P07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PrintLine(n);
            }
        }

        private static void PrintLine(int n)
        {
            int[] line = new int[n];
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = n;
            }

            Console.WriteLine(String.Join(" ",line));
        }
    }
}
