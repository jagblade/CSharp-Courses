using System;
using System.Collections.Generic;

namespace _01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                else if (charsCount.ContainsKey(input[i]))
                {
                    charsCount[input[i]]++;
                }
                else
                {
                    charsCount.Add(input[i], 1);
                }
            }

            foreach (var rqp in charsCount)
            {
                char currentChar = rqp.Key;
                int count = rqp.Value;

                Console.WriteLine($"{currentChar} -> {count}");
            }
        }
    }
}
