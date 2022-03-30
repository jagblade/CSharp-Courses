using System;

namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                Console.WriteLine(IsPalindrome(command));

                command = Console.ReadLine();   
            }
        }

        static bool IsPalindrome(string command)
        {
            string reverse = string.Empty;

            for (int i = command.Length - 1; i >= 0; i--)
            {
                reverse += command[i];
            }

            if (reverse == command)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
