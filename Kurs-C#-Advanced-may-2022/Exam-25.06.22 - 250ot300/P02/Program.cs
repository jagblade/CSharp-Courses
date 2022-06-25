using System;
using System.Linq;

namespace P02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            int col = 0;
            int row = 0;

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();

                if (matrix[i].Contains('V'))
                {
                    row = i;
                    col = Array.IndexOf(matrix[i], 'V');
                    matrix[row][col] = '*';
                }
            }
            int holes = 1;


            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "up")
                {
                    CheckPosition(row - 1, col);
                }
                else if (command == "down")
                {

                }
                else if (command == "left")
                {

                }
                else if (command == "right")
                {

                }
                

                command = Console.ReadLine();
            }
        }

        public string CheckPosition(int row, int col)
        {
            return "ToDo";
        }
    }
}
