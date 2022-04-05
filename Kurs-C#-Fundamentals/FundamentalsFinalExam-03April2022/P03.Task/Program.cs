using System;
using System.Collections.Generic;

namespace P03.Task
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestList =
                new Dictionary<string, List<string>>();

            int dislakedMeals = 0;

            string inputCmd = Console.ReadLine();

            while (inputCmd != "Stop")
            {
                string[] cmdArg = inputCmd.Split('-', StringSplitOptions.RemoveEmptyEntries);

                string likeCommand = cmdArg[0];
                string guest = cmdArg[1];
                string meal = cmdArg[2];

                if (likeCommand == "Like")
                {
                    
                    if (guestList.ContainsKey(guest))
                    {
                        if (!guestList[guest].Contains(meal))
                        {
                            guestList[guest].Add(meal);
                        }
                    }
                    else
                    {
                        guestList.Add(guest, new List<string> { meal });

                    }
                }
                else if (likeCommand == "Dislike")
                {
                    
                    if (!guestList.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else
                    {
                        if (guestList[guest].Contains(meal))
                        {
                            dislakedMeals++;
                            guestList[(guest)].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    
                }
                inputCmd = Console.ReadLine();
            }


            foreach (var guest in guestList)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {dislakedMeals}");
        }

    }
}
