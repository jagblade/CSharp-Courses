using System;

namespace P01.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string task = Console.ReadLine();

            while (task != "Done")
            {
                string[] cmdArg = task.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];

                if (command == "Change")
                {
                    input = input.Replace(cmdArg[1],cmdArg[2]);

                    Console.WriteLine(input);
                }
                else if (command == "Includes")
                {
                    bool isContained = input.Contains(cmdArg[1]);
                    Console.WriteLine(isContained);
                }
                else if (command == "End")
                {
                    bool isEnding = input.EndsWith(cmdArg[1]);
                    Console.WriteLine(isEnding);
                }
                else if (command == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    int indexOfChar = input.IndexOf(cmdArg[1]);
                    Console.WriteLine(indexOfChar);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);
                    input = input.Substring(startIndex, lenght);

                    Console.WriteLine(input);
                }

                task = Console.ReadLine();

            }
        }
    }
}
