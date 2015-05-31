using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Target_Practice
{
	class Program
	{
		static bool IsInside(int x0, int y0, int x1, int y1, int radius)
		{
			if ((x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1) <= radius * radius)
			{
				return true;
			}
			return false;
		}
		static void ShootTheMatrix(char[,] matrix, int x, int y, int radius)
		{
			for (int row = 0; row < matrix.GetLength(0); ++row)
			{
				for (int col = 0; col < matrix.GetLength(1); ++col)
				{
					if (IsInside(x, y, row, col, radius))
					{
						matrix[row, col] = ' ';
					}
				}
			}
		}

		static void Gravity(char[,] matrix)
		{
			for (int col = 0; col < matrix.GetLength(1); ++col)
			{
				bool moved = true;
				while (moved)
				{
					moved = false;
					for (int row = 0; row < matrix.GetLength(0) - 1; ++row)
					{
						if (matrix[row, col] != ' ' && matrix[row + 1, col] == ' ')
						{
							moved = true;
							matrix[row + 1, col] = matrix[row, col];
							matrix[row, col] = ' ';
						}
					}
				}
			}
		}

		static void FillTheMatrix(char[,] matrix, string str)
		{
			int stringIndex = 0;
			bool leftToRight = true;
			for (int i = matrix.GetLength(0) - 1; i >= 0; --i)
			{
				if (leftToRight)
				{
					for (int j = matrix.GetLength(1) - 1; j >= 0; --j)
					{
						if (stringIndex >= str.Length)
						{
							stringIndex = 0;
						}
						matrix[i, j] = str[stringIndex];
						++stringIndex;
					}
				}
				else
				{
					for (int j = 0; j < matrix.GetLength(1); ++j)
					{
						if (stringIndex >= str.Length)
						{
							stringIndex = 0;
						}
						matrix[i, j] = str[stringIndex];
						++stringIndex;
					}
				}
				leftToRight = !leftToRight;
			}
		}

		static void Main(string[] args)
		{
			int[] arrSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			char[,] inputMatrix = new char[arrSize[0], arrSize[1]];

			string str = Console.ReadLine();
			FillTheMatrix(inputMatrix, str);

			int[] shotInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			ShootTheMatrix(inputMatrix, shotInfo[0], shotInfo[1], shotInfo[2]);

			Gravity(inputMatrix);

			for (int i = 0; i < arrSize[0]; ++i)
			{
				for (int j = 0; j < arrSize[1]; ++j)
				{
					Console.Write(inputMatrix[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
