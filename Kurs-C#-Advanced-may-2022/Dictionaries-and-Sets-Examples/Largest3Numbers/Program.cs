using System;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse)
            .OrderByDescending(x => x).ToList().Take(3);
        Console.WriteLine(string.Join(" ", nums));
    }
}