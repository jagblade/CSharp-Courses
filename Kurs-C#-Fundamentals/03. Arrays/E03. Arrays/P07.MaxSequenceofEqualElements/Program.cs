using System;
using System.Linq;

namespace P07.MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int maxElement = 0;
            int maxCount = 0;

            int countedElement = 0;
            int count = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    countedElement = nums[i];
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (maxCount < count)
                {
                   maxElement = countedElement;
                   maxCount = count;
                }

            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxElement + " ");
            }


        }
    }
}