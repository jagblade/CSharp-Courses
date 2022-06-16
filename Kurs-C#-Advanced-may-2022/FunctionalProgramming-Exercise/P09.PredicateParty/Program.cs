using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            //"Peter Misha Stephen".Split() -> {"Peter", "Misha", "Stephen"}

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                //приема име -> връща true/ false ако името отговаря на даден критерий
                Predicate<string> predicate = GetPredicate(command);

                //command = "Double ....." или "Remove ....."
                if (command.StartsWith("Double"))
                {
                    //дублираме всички, които отговарят на даден критерий
                    //StartsWith, EndsWith, Length

                    //{Peter, Ivan, Dragan} -> {Peter, Peter, Ivan, Dragan}
                    for (int i = 0; i < people.Count; i++)
                    {
                        string person = people[i];
                        if (predicate(person))
                        {
                            people.Insert(i + 1, person);
                            i++;
                        }
                    }
                }
                else if (command.StartsWith("Remove"))
                {
                    //премахваме всички, които отговарят на даден критерий
                    //StartsWith, EndsWith, Length
                    people.RemoveAll(predicate);

                }


                command = Console.ReadLine();
            }

            //отпечатай гостите
            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string command)
        {
            //"Double StartsWith a".Split() -> ["Double", "StartsWith", "a"]
            string command2 = command.Split()[1]; ////StartsWith, EndsWith, Length
            string arg = command.Split()[2];

            Predicate<string> predicate = null;
            if (command2 == "StartsWith")
            {
                predicate = name => name.StartsWith(arg);
            }
            else if (command2 == "EndsWith")
            {
                predicate = name => name.EndsWith(arg);
            }
            else if (command2 == "Length")
            {
                //"Remove Length 3".Split() -> ["Remove", "Length", "3"]
                predicate = name => name.Length == int.Parse(arg);
            }
            return predicate;
        }
    }
}