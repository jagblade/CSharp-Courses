начин 1:
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    internal class Program
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

начин 2:
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
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