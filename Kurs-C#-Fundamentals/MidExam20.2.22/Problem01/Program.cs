using System;

namespace Problem01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xpNeeded = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());

            double gainedXP = 0;
            double xpFromCurrentBattle = double.Parse(Console.ReadLine());
            int currentBattle = 1;

            while (gainedXP < xpNeeded && currentBattle <= battlesCount)
            {
                if (currentBattle % 3 == 0 && currentBattle % 5 != 0 && currentBattle %15 != 0)
                {
                    xpFromCurrentBattle += xpFromCurrentBattle * 0.15;
                }
                else if (currentBattle % 5  == 0 && currentBattle % 15 != 0 && currentBattle % 3 != 0  )
                {
                    xpFromCurrentBattle -= xpFromCurrentBattle * 0.10;
                }
                else if ((currentBattle % 5 == 0 && currentBattle % 15 != 0 && currentBattle % 3 == 0))
                {
                    xpFromCurrentBattle -= xpFromCurrentBattle * 0.5;
                }
              
                else if (currentBattle % 15 == 0)
                {
                    xpFromCurrentBattle += xpFromCurrentBattle * 0.10;
                }       
                gainedXP += xpFromCurrentBattle;
                if (gainedXP >= xpNeeded)
                {
                    break;
                }
                if (currentBattle < battlesCount)
                {
                    xpFromCurrentBattle = double.Parse(Console.ReadLine());
                    
                }
                currentBattle++;

            }

            double neededExperience = xpNeeded - gainedXP;
            if (gainedXP >= xpNeeded)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {currentBattle} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:F2} more needed.");
            }
            
        }
    }
}
