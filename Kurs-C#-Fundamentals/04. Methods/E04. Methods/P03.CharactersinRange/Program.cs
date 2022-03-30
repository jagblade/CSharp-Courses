using System;

namespace P03.CharactersinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
          char start = char.Parse(Console.ReadLine());
          char end = char.Parse(Console.ReadLine());
          
            int startCharCode = (int)start;
            int endCharCode = (int)end;

            if ( startCharCode < endCharCode)
            {
                PrintChars(startCharCode, endCharCode);
            }
            else
            {
                PrintChars(endCharCode, startCharCode); 
            }

        }

        static void PrintChars(int startCharCode, int endCharCode)
        {
            for (int i = startCharCode + 1 ; i < endCharCode; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
        }
    }
}
