﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 5.0
namespace Class_Matrix
{
	public class Point : IComparable<Point>
	{
		public int Row { get; set; }
		public int Col { get; set; }

		public Point(int newRow, int newCol)
		{
			this.Row = newRow;
			this.Col = newCol;
		}

		public int CompareTo(Point other)
		{
			int comp = this.Row.CompareTo(other.Row);

			if (comp == 0)
			{
				comp = this.Col.CompareTo(other.Col);
			}

			return comp;
		}
	}

	public class Matrix<T> where T : IComparable<T>
	{
		private T[][] matrix;
		private Point startPoint;
		private Point currentPoint;
		private Point chekPoint;
		private T startElement;
		private int maxLengthRow;
		private int currentRowLength;
		private string spaceSeparator;
		public Point StartPoint
		{
			get => this.startPoint;
		}

		public Point CurrentPoint
		{
			get => this.currentPoint;

			set
			{
				if (this.IsValidIndex(value))
				{
					this.currentPoint = value;
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}

		public Point ChekPoint
		{
			get => this.chekPoint;

			set
			{
				if (this.IsValidIndex(value))
				{
					this.chekPoint = value;
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}

		public bool IsValidIndex(Point point)
		{
			bool isValid = ((point.Row >= 0) && (point.Row < this.MaxLengthRow));
			isValid = ((isValid) && (point.Col >= 0) && (point.Col < this.matrix[point.Row].Length));

			return isValid;
		}

		public int MaxLengthRow
		{
			get => this.maxLengthRow;

			private set
			{

			}
		}

		public int CurrentRowLength
		{
			get => this.currentRowLength;
			private set
			{

			}
		}

		public Matrix(string newSpaceSeparator, int newRow, int newCol = 0)
		{
			this.CreateMatrix(null, newSpaceSeparator, newRow, newCol);
		}

		public Matrix(T[,] newMatrix, string newSpaceSeparator)
		{
			int newRow = newMatrix.GetLength(0);
			int newCol = newMatrix.GetLength(1);

			this.CreateMatrix(newMatrix, newSpaceSeparator, newRow, newCol);
		}

		public void SetStartElement(T element)
		{
			this.startElement = element;
			this.SetStartPoint(this.startElement);
		}

		public void SetStartPoint(T newStartElement)
		{
			this.startElement = newStartElement;

			bool isLoopExit = false;
			int row = 0;

			while ((row < MaxLengthRow) && (!isLoopExit))
			{
				int col = 0;

				while ((col < this.matrix[row].Length) && (!isLoopExit))
				{
					if (this.matrix[row][col].Equals(newStartElement))
					{
						this.startPoint = new Point(row, col);
						isLoopExit = true;
					}

					col++;
				}

				row++;
			}

			this.SetStartToCurrentPoint();
		}

		public void SetStartToCurrentPoint()
		{
			this.CurrentPoint = new Point(this.startPoint.Row, this.startPoint.Col);
		}

		public void SetMatrixRow(int row, T[] colArr)
		{
			this.matrix[row] = colArr;

			this.SetLength();
		}

		public void SetCurrentElement(T element)
		{
			this.matrix[currentPoint.Row][currentPoint.Col] = element;
		}

		public T GetCurrentElement() => this.matrix[currentPoint.Row][currentPoint.Col];

		public void SetElementAtPosition(T element, Point point)
		{
			this.matrix[point.Row][point.Col] = element;
		}

		public T GetElementAtPosition(Point point) => this.matrix[point.Row][point.Col];

		public void SetSpaceSeparator(string newSpaceSeparator)
		{
			this.spaceSeparator = newSpaceSeparator;
		}

		public IEnumerable<Point> FoundAllElementPositions(T element)
		{
			Queue<Point> result = new Queue<Point>();

			for (int row = 0; row < this.matrix.Length; row++)
			{
				int maxCol = this.matrix[row].Length;

				for (int col = 0; col < maxCol; col++)
				{
					if (this.matrix[row][col].Equals(element))
					{
						Point newPoint = new Point(row, col);
						result.Enqueue(newPoint);
					}
				}
			}

			return result as IEnumerable<Point>;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			for (int row = 0; row < this.maxLengthRow; row++)
			{
				StringBuilder temp = new StringBuilder();

				int colLessOne = this.matrix[row].Length - 1;

				for (int col = 0; col < colLessOne + 1; col++)
				{
					if (col == colLessOne)
					{
						temp.Append(this.matrix[row][col].ToString());
					}
					else
					{
						temp.Append(this.matrix[row][col].ToString() + this.spaceSeparator);
					}
				}

				sb.AppendLine(temp.ToString());
			}

			return sb.ToString().TrimEnd();
		}

		public string GetChessCoordinates(Point position) => $"{((char)((int)'a' + position.Col)).ToString()}{position.Row + 1}";

		public Point ChangeCurrentPosition(Point newPoint, int stepRow, int stepCol)
		{
			Point result = null;
			if (this.currentPoint.Row == newPoint.Row)
			{
				result = new Point(newPoint.Row, this.matrix[this.currentPoint.Row].Length + (-1) * newPoint.Col * stepCol);
			}
			else if (currentPoint.Col == newPoint.Col)
			{
				result = new Point(this.MaxLengthRow + (-1) * newPoint.Row * stepRow, newPoint.Col);
			}

			try
			{
				this.CurrentPoint = result;
			}
			catch (IndexOutOfRangeException)
			{

				result = new Point(-1, -1);
			}

			return result;
		}

		private void CreateMatrix(T[,] newMatrix, string newSpaceSeparator, int newRow, int newCol)
		{
			this.matrix = new T[newRow][];

			if (newMatrix == null)
			{
				for (int row = 0; row < newRow; row++)
				{
					T[] temp = new T[newCol];
					this.matrix[row] = temp;
				}
			}
			else
			{
				for (int row = 0; row < newRow; row++)
				{
					T[] temp = new T[newCol];
					this.matrix[row] = temp;

					for (int col = 0; col < newCol; col++)
					{
						this.matrix[row][col] = newMatrix[row, col];
					}
				}
			}

			this.SetLength();
			this.SetSpaceSeparator(newSpaceSeparator);
		}

		private void SetLength()
		{
			this.maxLengthRow = this.matrix.Length;
		}

		public int GetCurrentCol(int row)
		{
			this.SetCurrentCol(row);
			return this.CurrentRowLength;
		}
		private void SetCurrentCol(int row)
		{
			this.CurrentRowLength = this.matrix[row].Length;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			const char VANKO = 'V';
			const char HOLE = '*';
			const char RODS = 'R';
			const char CABLES = 'C';
			const char ELDIED = 'E';
			const char FREE = '-';

			int n = int.Parse(Console.ReadLine());

			Matrix<char> wall = new Matrix<char>(string.Empty, n, n);

			for (int i = 0; i < n; i++)
			{
				char[] temp = Console.ReadLine().ToCharArray();
				wall.SetMatrixRow(i, temp);
			}

			wall.SetStartElement(VANKO);
			wall.SetElementAtPosition(HOLE, wall.CurrentPoint);

			bool isLoopExit = false;
			int holeCount = 1;
			int countOfRods = 0;
			bool isDied = false;

			StringBuilder sb = new StringBuilder();

			while (!isLoopExit)
			{
				string input = Console.ReadLine();

				if (input.Equals("End"))
				{
					isLoopExit = true;
				}
				else
				{
					int stepRow = 0;
					int stepCol = 0;

					switch (input)
					{
						case "up":
							stepRow--;
							break;
						case "down":
							stepRow++;
							break;
						case "left":
							stepCol--;
							break;
						case "right":
							stepCol++;
							break;
						default:
							break;
					}

					Point newPosition = new Point(wall.CurrentPoint.Row + stepRow, wall.CurrentPoint.Col + stepCol);

					if (wall.IsValidIndex(newPosition))
					{
						char ch = wall.GetElementAtPosition(newPosition);
						if (ch == CABLES)
						{
							isLoopExit = true;
							isDied = true;
							wall.SetElementAtPosition(ELDIED, newPosition);
							holeCount++;
						}
						else if (ch == FREE)
						{
							wall.CurrentPoint = newPosition;
							wall.SetElementAtPosition(HOLE, newPosition);
							holeCount++;
						}
						else if (ch == RODS)
						{
							countOfRods++;
							sb.AppendLine("Vanko hit a rod!");
						}
						else if (ch == HOLE)
						{
							wall.CurrentPoint = newPosition;
							sb.AppendLine($"The wall is already destroyed at position [{wall.CurrentPoint.Row}, {wall.CurrentPoint.Col}]!");
						}
					}
				}
			}

			if (isDied)
			{
				sb.AppendLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
			}
			else
			{
				sb.AppendLine($"Vanko managed to make {holeCount} hole(s) and he hit only {countOfRods} rod(s).");
				wall.SetElementAtPosition(VANKO, wall.CurrentPoint);
			}

			sb.AppendLine(wall.ToString().TrimEnd());

			Console.WriteLine(sb.ToString().TrimEnd());
		}
	}
}

