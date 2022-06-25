using System;

namespace WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vankoCoordinates = new int[2];
            var vankoOldCoordinates = new int[2];
            var holesCounter = 1;
            var rodCounter = 0;
            var isVankoElecricified = false;

            var matrixSize = int.Parse(Console.ReadLine());

            var matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                var rowImput = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowImput[col];

                    if (matrix[row, col] == 'V')
                    {
                        vankoCoordinates[0] = row;
                        vankoCoordinates[1] = col;
                    }
                }
            }

            var userComand = Console.ReadLine();

            while (userComand != "End")
            {
                var newPosition = Move(vankoCoordinates, userComand);

                if (!IsInRange(matrixSize, newPosition))
                {
                    userComand = Console.ReadLine();
                    continue;
                }

                if (matrix[newPosition[0], newPosition[1]] == 'C')
                {
                    holesCounter++;
                    isVankoElecricified = true;
                    matrix[newPosition[0], newPosition[1]] = 'E';
                    if (matrix[vankoCoordinates[0], vankoCoordinates[1]] != 'R')
                    {
                        matrix[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                    }
                    vankoCoordinates = newPosition;
                    break;
                }
                else if (matrix[newPosition[0], newPosition[1]] == 'R')
                {
                    //not make hole
                    rodCounter++;
                    Console.WriteLine("Vanko hit a rod!");
                }
                else if (matrix[newPosition[0], newPosition[1]] == '*')
                {
                    matrix[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                    vankoOldCoordinates = vankoCoordinates;
                    vankoCoordinates = newPosition;
                    Console.WriteLine($"The wall is already destroyed at position [{vankoCoordinates[0]}, {vankoCoordinates[1]}]!");
                }
                else if (matrix[newPosition[0], newPosition[1]] == '-')
                {
                    holesCounter++;
                    matrix[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                    vankoOldCoordinates = vankoCoordinates;
                    vankoCoordinates = newPosition;
                }
                userComand = Console.ReadLine();
            }

            if (isVankoElecricified)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCounter} hole(s).");
            }
            else
            {
                matrix[vankoCoordinates[0], vankoCoordinates[1]] = 'V';
                Console.WriteLine($"Vanko managed to make {holesCounter} hole(s) and he hit only {rodCounter} rod(s).");
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInRange(int matrixSize, int[] coordinates)
            => coordinates[0] >= 0 && coordinates[0] < matrixSize
                && coordinates[1] >= 0 && coordinates[1] < matrixSize;

        private static int[] Move(int[] position, string directionCommand)
        {
            var row = position[0];
            var col = position[1];
            var newPosition = new int[2];

            if (directionCommand == "up")
            {
                newPosition[0] = row - 1;
                newPosition[1] = col;
            }
            else if (directionCommand == "down")
            {
                newPosition[0] = row + 1;
                newPosition[1] = col;
            }
            else if (directionCommand == "left")
            {
                newPosition[0] = row;
                newPosition[1] = col - 1;
            }
            else if (directionCommand == "right")
            {
                newPosition[0] = row;
                newPosition[1] = col + 1;
            }

            return newPosition;
        }
    }
}
