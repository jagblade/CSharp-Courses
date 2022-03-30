using System;
using System.Linq;

namespace P06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            bool isNotFound = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (
                    int j = i - 1; j >= 0; j--)
                {
                    leftSum += arr[j];
                };

                for (int k = i+1; k <= arr.Length - 1 ; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isNotFound = false;
                    break;
                }

            }

            if (isNotFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
