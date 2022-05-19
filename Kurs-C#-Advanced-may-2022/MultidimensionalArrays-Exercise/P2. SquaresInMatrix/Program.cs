using System;

namespace _2._Squares_in_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //"3 4".Split() -> ["3", "4"]
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix);

            int count = 0; //брой на матриците 2х2

            // A B B D
            // E B B B
            // I J B B


            //елемент == елемент от дясно == елемент долу == елемент по диагонал
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] //елемент в дясно
                        && matrix[row, col] == matrix[row + 1, col] //елемент долу
                        && matrix[row, col] == matrix[row + 1, col + 1]) //елемент по диагонал)
                    {
                        //матрица 2х2, на която всички елементи са еднакви
                        count++;
                    }

                }
            }

            Console.WriteLine(count);
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(); //"A B B D".Split() -> ["A", "B", "B", "D"]
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}