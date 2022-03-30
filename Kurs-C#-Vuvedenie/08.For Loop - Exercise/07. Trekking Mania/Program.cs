using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            


            for (int i = 0; i < n; i++)
            {
                int group = int.Parse(Console.ReadLine());

                if (group <= 5)
                {
                    musala += group;
                }
                else if (group <= 12)
                {
                    monblan += group;
                }
                else if (group <= 25)
                {
                    kilimanjaro += group;
                }
                else if (group <= 40)
                {
                    k2 += group;
                }
                else
                {
                    everest += group;
                }
            }
            double peopleTotal = musala + monblan + kilimanjaro + k2 + everest;
            double pMusala = musala / peopleTotal * 100;
            double pMonblan = monblan / peopleTotal * 100;
            double pKilimanjaro= kilimanjaro / peopleTotal * 100;
            double pK2 = k2 / peopleTotal * 100;
            double pEverest = everest / peopleTotal * 100;

            Console.WriteLine($"{pMusala:f2}%");
            Console.WriteLine($"{pMonblan:f2}%");
            Console.WriteLine($"{pKilimanjaro:f2}%");
            Console.WriteLine($"{pK2:f2}%");
            Console.WriteLine($"{pEverest:f2}%");

        }
    }
}
