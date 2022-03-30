using System;

namespace _02._Numbers_Nto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
