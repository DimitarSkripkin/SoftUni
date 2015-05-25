using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillTheMatrix
{
	static void FillPatternA(int[,] arr)
	{
		int cellValue = 1;
		for (int column = 0; column < arr.GetLength(1); ++column)
		{
			for (int row = 0; row < arr.GetLength(0); ++row)
			{
				arr[row, column] = cellValue;
				++cellValue;
			}
		}
	}

	static void FillPatternB(int[,] arr)
	{
		int cellValue = 1;
		bool reverseDirection = false;
		for (int column = 0; column < arr.GetLength(1); ++column)
		{
			if (reverseDirection)
			{
				for (int row = arr.GetLength(0) - 1; row >= 0; --row)
				{
					arr[row, column] = cellValue;
					++cellValue;
				}
			}
			else
			{
				for (int row = 0; row < arr.GetLength(0); ++row)
				{
					arr[row, column] = cellValue;
					++cellValue;
				}
			}
			reverseDirection = !reverseDirection;
		}
	}

	static void PrintMatrix(int[,] arr)
	{
		for (int row = 0; row < arr.GetLength(0); ++row)
		{
			for (int column = 0; column < arr.GetLength(1); ++column)
			{
				Console.Write("{0} ", arr[row, column]);
			}
			Console.WriteLine();
		}
	}

	static void Main(string[] args)
	{
		int matrixSize = int.Parse(Console.ReadLine());
		int[,] matrix = new int[matrixSize, matrixSize];

		Console.WriteLine();
		FillPatternA(matrix);
		PrintMatrix(matrix);

		Console.WriteLine();
		FillPatternB(matrix);
		PrintMatrix(matrix);
	}
}