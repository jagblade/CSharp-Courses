
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    internal class Variant2
    {
        static void V2(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            //Func<име, модифицирано име> 

            Action<string> printPrefix = name => Console.WriteLine("Sir " + name);

            foreach (string name in names)
            {
                printPrefix(name);
            }
        }
    }
}