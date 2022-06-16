using System;
using System.Linq;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int treshold = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");
            Console.WriteLine(names.First(name => name.Select(symbol => (int)symbol).Sum() >= treshold));
        }
    }
}