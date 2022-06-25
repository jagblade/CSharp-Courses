using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whiteInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] grayInput = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> white = new Stack<int>(whiteInput);
            Queue<int> gray = new Queue<int>(grayInput);

            Dictionary<string, List<int>> locations = new Dictionary<string, List<int>>()
            {
                {"Floor",new List<int>{0,0} },
                {"Countertop",new List<int>(){ 0,60 }},
                {"Oven",new List<int>(){ 0,50 }},
                {"Sink",new List<int>(){ 0,40 } },
                {"Wall",new List<int>(){ 0,70 }}
            };


            while (white.Any()&& gray.Any())
            {
                if (gray.Peek() == white.Peek())
                {
                    
                    int newTile = white.Peek() + gray.Peek();
                    white.Pop();
                    gray.Dequeue();

                    bool isUsed = false;
                    foreach (var loc in locations)
                    {
                        if (loc.Value[1] == newTile)
                        {
                            loc.Value[0]++;
                            isUsed = true;
                            break;
                        }
                    }

                    if (!isUsed)
                    {
                        locations["Floor"][0]++;
                    }
                }
                else
                {
                    int newWhite = white.Pop() / 2;
                    white.Push(newWhite);

                    int returnGray = gray.Dequeue();
                    gray.Enqueue(returnGray);
                }
            }


            if (white.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: " + string.Join(", ", white));
            }
            if (gray.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: " + string.Join(", ", gray));
            }

            foreach (var loc in locations)
            {
                if (loc.Value[0] > 0)
                {
                    Console.WriteLine($"{loc.Key}: {loc.Value[0]}");
                }
                
            }
        }
    }
}
