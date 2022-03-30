using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n; i++)
            {
                if (IsDivByEight(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }               ;
            }
        }

        private static bool HasOddDigit(int n)
        {
            int currentDigit = n;

            while (currentDigit != 0)
            {
                if (currentDigit % 2 != 0)
                {
                    return true;
                } 
                currentDigit /= 10;
            }
            return false;
        }

        private static bool IsDivByEight(int i)
        {
            int sumDigits = 0;
            int currentDigit = i;

            while (currentDigit != 0)
            {
                sumDigits += currentDigit % 10;
                currentDigit /= 10;
            }

            return (sumDigits % 8 == 0);
        }
    }
}
