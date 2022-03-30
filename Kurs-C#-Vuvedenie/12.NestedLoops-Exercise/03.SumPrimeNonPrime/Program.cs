using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = 0;

            int primeSum = 0;
            int nonPrimeSum = 0;

            bool isPrime;

            while (input != "stop")
            {
                isPrime = true;
                num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (num > 0)
                {
                    if (isPrime)
                    {
                        primeSum += num;
                    }
                    else
                    {
                        nonPrimeSum += num;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

        }
    }
}
