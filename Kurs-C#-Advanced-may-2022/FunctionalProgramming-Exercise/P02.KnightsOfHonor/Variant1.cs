using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    internal class Variant1
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            //Func<име, модифицирано име> 

            Func<string, string> addPrefix = name => "Sir " + name;

            foreach (string name in names)
            {
                Console.WriteLine(addPrefix(name));
            }
        }
    }
}
