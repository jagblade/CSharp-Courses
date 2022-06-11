using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            //"Lucas Noah Tea".Split() -> {"Lucas", "Noah", "Tea"}

            //име -> отпечатваме           

            Action<string> print = name => Console.WriteLine(name);
            list.ForEach(print);
        }
    }
}
