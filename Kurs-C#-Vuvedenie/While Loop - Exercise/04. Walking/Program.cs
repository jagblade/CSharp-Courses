using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int stepsCount = 0;

            while (steps != "Going home")
            {
                int stepsAsNumber = int.Parse(steps);
                stepsCount = stepsCount + stepsAsNumber;
                steps = Console.ReadLine();


                if (stepsCount >= 10000)
                {
                    break;
                }

            }
            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                int stepsAsNumber = int.Parse(steps);
                stepsCount = stepsCount + stepsAsNumber;
            }
            if (stepsCount < 10000)
            {
                Console.WriteLine($"{10000 - stepsCount} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                if (stepsCount > 10000)
                {
                    Console.WriteLine($"{stepsCount-10000} steps over the goal!");
                }
            }
        }
    }
}
