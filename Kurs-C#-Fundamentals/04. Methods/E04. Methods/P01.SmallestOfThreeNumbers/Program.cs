using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[3];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            SmallestNumber(elements);
        }

        static void SmallestNumber(int[] elements)
        {
            int smallestElement = elements[0];

            for (int i = 1; i <= elements.Length - 1 ; i++)
            {
                if (smallestElement > elements[i])
                {
                     smallestElement = elements[i];
                }
                
            }

            Console.WriteLine(smallestElement);
        }
    }
}
