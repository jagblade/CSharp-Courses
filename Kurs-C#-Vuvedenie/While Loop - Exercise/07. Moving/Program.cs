using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freespace = width * length * height;
            int sum = 0;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int currentCubic = int.Parse(command);
                sum += currentCubic;
                if (freespace < sum)
                {
                    int neededCubics = sum - freespace;
                    Console.WriteLine($"No more free space! You need {neededCubics} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                int freeCubics = freespace - sum;
                Console.WriteLine($"{freeCubics} Cubic meters left.");
            }
        }
    }
}
