using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> result = new List<string>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                result.AddRange(arrays[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(string.Join(" ",result));
                
        }
    }
}
