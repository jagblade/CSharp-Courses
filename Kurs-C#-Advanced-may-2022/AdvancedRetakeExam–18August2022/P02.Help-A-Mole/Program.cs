using System;
using System.Text;
using System.Collections.Generic;

namespace P02.Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            int points = 0;

            int moleStartRow = -1;
            int moleStartCol = -1;
            int specialOneRow = -1;
            int specialTwoRow = -1;
            int specialOneCol = -1;
            int specialTwoCol = -1;

            for (int row = 0; row < n; row++)
            {
                var element = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = element[col];
                    if (field[row, col] == 'M')
                    {
                        moleStartRow = row;
                        moleStartCol = col;
                        field[row, col] = '-';
                    }
                    if (field[row, col] == 'S')
                    {
                        if (specialOneCol != -1 && specialOneRow != -1)
                        {
                            specialTwoRow = row;
                            specialTwoCol = col;
                        }
                        else
                        {
                            specialOneRow = row;
                            specialOneCol = col;
                        }
                        
                    }
                }
              

            }

            string cmd = Console.ReadLine();
            int currentRow = moleStartRow;
            int currentCol = moleStartCol;

            while (cmd != "End" && points < 25)
            {


                if (cmd == "up")
                {
                    if (IsInTheField(currentRow - 1 , currentCol, field))
                    {
                        currentRow--;
                        CurrentPosition(currentRow, currentCol, field[currentRow,currentCol]);
                    }
                    else
                    {
                        Console.WriteLine(NoEscape()); 
                    }
                }
                else if(cmd == "down")
                {
                    if (IsInTheField(currentRow +1, currentCol, field))
                    {
                        currentRow++;
                        CurrentPosition(currentRow, currentCol, field[currentRow, currentCol]);
                    }
                    else
                    {
                        Console.WriteLine(NoEscape());
                    }
                }
                else if (cmd == "left")
                {
                    if (IsInTheField(currentRow, currentCol-1, field))
                    {
                        currentCol--;
                        CurrentPosition(currentRow, currentCol, field[currentRow, currentCol]);
                    }
                    else
                    {
                        Console.WriteLine(NoEscape());
                    }
                }
                else if (cmd == "right")
                {
                    if (IsInTheField(currentRow, currentCol+1, field))
                    {
                        currentCol++;
                        CurrentPosition(currentRow, currentCol, field[currentRow, currentCol]);
                    }
                    else
                    {
                        Console.WriteLine(NoEscape());
                    }
                }


                cmd = Console.ReadLine();
            }

            
            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }

           field[currentRow, currentCol] = 'M';

           var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(field[i,j]);
                }
                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString().TrimEnd()); 

         static bool IsInTheField(int row, int col, char[,] field)
        {
            return row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
        }
         static string NoEscape()
        {
            return "Don't try to escape the playing field!";
        }
         void CurrentPosition(int row,int col,char symbol)
        {
                if (symbol == 'S')
                {
                    // ToDo
                    if (row == specialOneRow && col == specialOneCol)
                    {
                        currentRow = specialTwoRow;
                        currentCol = specialTwoCol;
                    }
                    else
                    {
                        currentRow = specialOneRow;
                        currentCol = specialOneCol;
                    }

                    points -= 3;
                    field[specialOneRow, specialOneCol] = '-';
                    field[specialTwoRow, specialTwoCol] = '-';
                }
                else if (char.IsDigit(symbol))
                {
                    int intVal = int.Parse(symbol.ToString());
                    points += intVal;
                    field[row, col] = '-';
                }
            }
        }


        }


    }
