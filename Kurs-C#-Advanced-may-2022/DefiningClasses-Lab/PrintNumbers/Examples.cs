﻿using System;
using System.Linq;

class PrintNumbers
{

    static int Parse(string str)
    {
        int result = int.Parse(str);
        return result;
    }

    static int ParseVariant2(String str) => int.Parse(str);

    static void Main()
    {
        Func<string, int> parseVariant3 = (String str) => int.Parse(str);

        string input = Console.ReadLine();
        //int[] nums = StringToNums(input, ParseVariant2);
        //int[] nums = StringToNums(input, Parse);
        //int[] nums = StringToNums(input, parseVariant3);
        int[] nums = StringToNums(input, int.Parse);
        Console.WriteLine(nums.Count());
        Console.WriteLine(nums.Sum());
    }

    static int[] StringToNums(string input, Func<string, int> parseFunc)
    {
        return input.Split(", ").Select(parseFunc).ToArray();
    }
}