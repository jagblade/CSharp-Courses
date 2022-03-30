using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int minNum = int.MaxValue;

            while (command != "Stop")
            {

                int num = int.Parse(command);
                if (num < minNum)
                {
                    minNum = num;
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(minNum);
        }
    }
}

