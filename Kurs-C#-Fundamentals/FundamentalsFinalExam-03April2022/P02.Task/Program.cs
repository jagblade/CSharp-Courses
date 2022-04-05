using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\%|\$)(?<tag>[A-Z][a-z]{2,})(\1):\s(\[?(?<code>\d{1,3})\]\|){1,3}$";
            Dictionary<string, string> results = new Dictionary<string, string>();



            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match currentLine = Regex.Match(text, pattern);
                if (currentLine.Success)
                {
                    string tag = currentLine.Groups["tag"].Value;

                    string result = string.Empty;

                    for (int k = 0; k < currentLine.Groups["code"].Length; k++)
                    {
                        var digit = currentLine.Groups["code"].Captures[k].Value;

                        char c = (char)(int.Parse(digit));

                        result = result + c;
                    }

                    Console.WriteLine($"{tag}: {result}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
