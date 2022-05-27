using System;
using System.Linq;

// To Do 40/100

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            //пълним матрицата
            for (int row = 0; row < rows; row++)
            {
                //"10 20 30" -> ["10", "20", "30"] -> [10, 20, 30]
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            //анализ на матрицата
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(el => el * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(el => el / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el / 2).ToArray();
                }
            }

            //команди
            string command = Console.ReadLine();

            while (command != "End")
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int value = int.Parse(command.Split()[3]);

                if (command.StartsWith("Add"))
                {
                    //•	"Add {row} {column} {value}".Split => ["Add", "3", "1", "10"]                 
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] = matrix[row][col] + value;
                        //matrix[row][col] += value
                    }
                }
                else if (command.StartsWith("Subtract"))
                {
                    //•	"Subtract {row} {column} {value}"
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] = matrix[row][col] - value;
                        //matrix[row][col] -= value
                    }
                }



                command = Console.ReadLine();
            }

            //печатаме матрицата
            foreach (int[] row in matrix)
            {
                //row -> int [3, 4, 5]
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}
