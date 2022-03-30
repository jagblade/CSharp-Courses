using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int maxNum = int.MinValue;

            while (command != "Stop")
            {
                
                int num = int.Parse(command); 
                if (num > maxNum)
                {
                    maxNum = num;
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(maxNum);
        }
    }
}
