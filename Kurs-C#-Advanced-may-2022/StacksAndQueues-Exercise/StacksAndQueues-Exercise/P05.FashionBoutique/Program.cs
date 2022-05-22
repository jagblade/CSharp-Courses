using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothesValues = new Stack<int>(inputValues);

            int racks = 1;
            int sum = 0;

            while (clothesValues.Any())
            {
                if (sum + clothesValues.Peek() <= rackCapacity)
                {
                    sum += clothesValues.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}