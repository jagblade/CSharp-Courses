using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {

                string[] line = command.Split(" ");
                string action = line[0];

                if (action == "Insert")
                {
                    int itemToAdd = int.Parse(line[1]);
                    numbers.Insert(int.Parse(line[2]), itemToAdd);
                   
                }
                else if (action == "Delete")
                {
                    int itemToDelete = int.Parse(line[1]);
                    numbers.RemoveAll(x => x == itemToDelete);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
