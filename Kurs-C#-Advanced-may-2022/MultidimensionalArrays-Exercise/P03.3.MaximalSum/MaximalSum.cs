using System;
using System.Linq;

namespace P03._3.MaximalSum
{
    internal class MaximalSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix);

            int maxMatrixSum = 0;
            int maxStartCol = 0;
            int maxStartRow  = 0;

            
            for (int row = 0; row < rows  - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = SumMatrix(row, col, rows, cols, matrix);
                    if (maxMatrixSum < currentSum )
                    {
                        maxMatrixSum = currentSum;
                        maxStartRow = row;
                        maxStartCol = col;
                    }

                }
            }

            PrintMatrix(maxMatrixSum,maxStartRow, maxStartCol, matrix);


        }
        private static void PrintMatrix(int sum, int row,int col, int[,] matrix)
        {
            Console.WriteLine("Sum = "+sum);
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(matrix[row+i, col+k]+" ");
                }
                Console.WriteLine();
            }
        }

        private static int SumMatrix(int row, int col,int rows,int cols, int[,] matrix)
        {

            if (rows-row > 1 && cols - col > 1)
            {
                int currentSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        currentSum += matrix[row+i, col+j];
                    }
                }

                return currentSum;
            }
            else return 0;
            

        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
