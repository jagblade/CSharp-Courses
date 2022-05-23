using System;
using System.Collections.Generic;
using System.Linq;

class CountElements
{
    static void Main()
    {
        var countByNum = new Dictionary<double, int>();
        var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        foreach (var num in nums)
        {
            if (countByNum.ContainsKey(num))
            {
                countByNum[num]++;
            }
            else
            {
                countByNum[num] = 1;
            }
        }
        foreach (var pair in countByNum)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value} times");
        }
    }
}