using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> cmd = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (cmd[0] != "Done")
            {
                //"Add Book | {book name}"
                if (cmd[0] == "Add Book") 
                {
                    if (!(books.Contains(cmd[1])))
                    {
                        books.Insert(0, cmd[1]);
                    }
                    
                }
                //"Take Book | {book name}"
                else if (cmd[0] == "Take Book")
                {
                    if (books.Any(x => x == cmd[1]))
                    {
                        
                        books.Remove(cmd[1]);
                    }
                    
                }
                //"Swap Books | {book1} | {book2}"
                else if (cmd[0] == "Swap Books")
                {
                    if ((books.Contains(cmd[1])) && (books.Contains(cmd[2])))
                    {
                        string book1 = cmd[1];
                        string book2 = cmd[2];
                        int book1Pos = books.IndexOf(book1);
                        int book2Pos = books.IndexOf(book2);

                        books[book1Pos] = book2;
                        books[book2Pos] = book1;

                    }
                    

                }
                //"Insert Book | {book name}"
                else if (cmd[0] == "Insert Book")
                {
                    if (!(books.Contains(cmd[1])))
                    {
                        books.Add(cmd[1]);
                    }
                }
                //"Check Book | {index}"")
                else if (cmd[0] == "Check Book")
                {
                    int index = int.Parse(cmd[1]);
                    if ( index <= books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                }


                cmd = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine(string.Join(", ",books));
        }
    }
}
