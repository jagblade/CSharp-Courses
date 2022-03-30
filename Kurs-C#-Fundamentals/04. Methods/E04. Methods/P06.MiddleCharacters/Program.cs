using System;

namespace P06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddle(input);
        }

        static void PrintMiddle(string input)
        {

            int middle = input.Length / 2;

            if (input.Length % 2 != 0)
            {
                Console.WriteLine((char)input[middle]);
            }
            else
            {
                Console.WriteLine(input.Substring(middle - 1, 2));
            }
        }
    }
}
