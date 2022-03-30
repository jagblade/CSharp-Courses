using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
