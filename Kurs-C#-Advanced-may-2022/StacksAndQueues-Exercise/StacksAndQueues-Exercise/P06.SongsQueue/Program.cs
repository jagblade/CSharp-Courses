using System;
using System.Collections.Generic;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

            //stop: песните свършат
            //продължаваме: имаме песни

            while (songsQueue.Count > 0)
            {
                //изпълнявам команда
                string command = Console.ReadLine();
                //"Play"
                if (command == "Play")
                {
                    songsQueue.Dequeue(); //пускаме първата песен
                }
                //"Add {song}".Split() -> ["Add", "{song}"]
                else if (command.Contains("Add"))
                {
                    //"Add Watch Me"
                    string song = command.Substring(4);
                    //да я има -> "{song} is already contained!"
                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    //да я няма -> слагаме на опашката
                    else
                    {
                        songsQueue.Enqueue(song);

                    }
                }
                //"Show" 
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}