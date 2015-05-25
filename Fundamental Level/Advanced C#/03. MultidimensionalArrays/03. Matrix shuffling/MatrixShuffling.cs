using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixShuffling
{
	static void Swap(string[,] arr, int x1, int y1, int x2, int y2)
	{
		// arr[ row, column ]
		string temp = arr[x1, y1];
		arr[x1, y1] = arr[x2, y2];
		arr[x2, y2] = temp;
	}

	static void PrintMatrix(string[,] arr)
	{
		for (int i = 0; i < arr.GetLength(0); ++i)
		{
			for (int j = 0; j < arr.GetLength(1); ++j)
			{
				Console.Write("{0} ", arr[i, j]);
			}
			Console.WriteLine();
		}
	}

	static void Main(string[] args)
	{
		string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		int n = int.Parse(input[0]),
			m = int.Parse(input[1]);
		string[,] matrix = new string[n, m];

		for (int i = 0; i < n; ++i)
		{
			input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			for (int j = 0; j < m; ++j)
			{
				matrix[i, j] = input[j];
			}
		}

		input = Console.ReadLine().Split(' ');
		string command = input[0];
		while (command != "END")
		{
			if (command == "swap")
			{
				int x1 = int.Parse(input[1]), y1 = int.Parse(input[2]),
					x2 = int.Parse(input[3]), y2 = int.Parse(input[4]);

				// dadeniq primer polzva za redove X i za koloni Y
				if (x1 < 0 || x1 >= matrix.GetLength(0) || y1 < 0 || y1 >= matrix.GetLength(1)
					|| x2 < 0 || x2 >= matrix.GetLength(0) || y2 < 0 || y2 >= matrix.GetLength(1))
				{
					Console.WriteLine("Invalid input");
				}
				else
				{
					Swap(matrix, x1, y1, x2, y2);
					PrintMatrix(matrix);
				}
			}
			else
			{
				Console.WriteLine("Invalid input");
			}
			input = Console.ReadLine().Split(' ');
			command = input[0];
		}
	}
}