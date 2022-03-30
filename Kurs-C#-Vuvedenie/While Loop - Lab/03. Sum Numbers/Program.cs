using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            int sum = 0;

            do
            {
                int nextNumber = int.Parse(Console.ReadLine());
                sum += nextNumber;

            } while (sum < target);
           

            Console.WriteLine(sum);
        }
    }
}
