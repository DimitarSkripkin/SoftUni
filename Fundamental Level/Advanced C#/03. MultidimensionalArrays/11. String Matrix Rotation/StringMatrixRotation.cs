using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringMatrixRotation
{
	static char[,] RotateMatrix(List<string> inputMatrix, int degrees)
	{
		int longestLenght = inputMatrix.Max(p => p.Length);
		char[,] outputMatrix = new char[1, 1];

		degrees %= 360;
		switch (degrees)
		{
			case 90:
			case 180:
			case 270:
				break;
			default:
				degrees = 0;
				break;
		}

		switch (degrees)
		{
			case 0:
				outputMatrix = new char[inputMatrix.Count, longestLenght];

				for (int row = 0; row < outputMatrix.GetLength(0); ++row)
				{
					for (int col = 0; col < outputMatrix.GetLength(1); ++col)
					{
						if (inputMatrix[row].Length > col)
						{
							outputMatrix[row, col] = inputMatrix[row][col];
						}
						else
						{
							outputMatrix[row, col] = ' ';
						}
					}
				}
				break;
			case 90:
				outputMatrix = new char[longestLenght, inputMatrix.Count];

				for (int row = 0; row < outputMatrix.GetLength(0); ++row)
				{
					for (int col = 0; col < outputMatrix.GetLength(1); ++col)
					{
						if (inputMatrix[inputMatrix.Count - col - 1].Length > row)
						{
							outputMatrix[row, col] = inputMatrix[inputMatrix.Count - col - 1][row];
						}
						else
						{
							outputMatrix[row, col] = ' ';
						}
					}
				}
				break;
			case 180:
				outputMatrix = new char[inputMatrix.Count, longestLenght];

				for (int row = 0; row < outputMatrix.GetLength(0); ++row)
				{
					for (int col = 0; col < outputMatrix.GetLength(1); ++col)
					{
						int inputMatrixRowLenght = inputMatrix[inputMatrix.Count - row - 1].Length;
						if (inputMatrixRowLenght > col)
						{
							outputMatrix[row, col] = inputMatrix[inputMatrix.Count - row - 1][inputMatrixRowLenght - col - 1];
						}
						else
						{
							outputMatrix[row, col] = ' ';
						}
					}
				}
				break;
			case 270:
				outputMatrix = new char[longestLenght, inputMatrix.Count];

				for (int row = 0; row < outputMatrix.GetLength(0); ++row)
				{
					for (int col = 0; col < outputMatrix.GetLength(1); ++col)
					{
						if (inputMatrix[col].Length >= outputMatrix.GetLength(0) - row)
						{
							outputMatrix[row, col] = inputMatrix[col][outputMatrix.GetLength(0) - row - 1];
						}
						else
						{
							outputMatrix[row, col] = ' ';
						}
					}
				}
				break;
		}

		return outputMatrix;
	}

	static void Main(string[] args)
	{
		int degrees = int.Parse(Console.ReadLine().Split(new[] { '(', ')' })[1]);

		List<string> inputMatrix = new List<string>();
		string inputLine = Console.ReadLine();
		while (inputLine != "END")
		{
			inputMatrix.Add(inputLine);
			inputLine = Console.ReadLine();
		}

		var output = RotateMatrix(inputMatrix, degrees);

		for (int row = 0; row < output.GetLength(0); ++row)
		{
			for (int col = 0; col < output.GetLength(1); ++col)
			{
				Console.Write(output[row, col]);
			}
			Console.WriteLine();
		}
	}
}
