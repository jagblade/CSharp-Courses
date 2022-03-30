using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int oddSum;
            int evenSum;

            string currentNum;

            for (int num = first; num <= second; num++)
            {
                oddSum = 0;
                evenSum = 0;

                currentNum = num.ToString();

                for (int i = 0; i < currentNum.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += currentNum[i];
                    }
                    else
                    {
                        oddSum += currentNum[i];
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
