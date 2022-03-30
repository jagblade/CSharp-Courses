using System;
using System.Linq;

namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            int comparedNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length - 1 ; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == comparedNumber)
                    {
                        Console.WriteLine(nums[i]+" "+nums[j]);
                    }
                }
            }
        }
    }
}
