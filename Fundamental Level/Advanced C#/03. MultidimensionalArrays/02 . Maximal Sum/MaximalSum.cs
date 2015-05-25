using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
	struct max_sum
	{
		public int posX, posY, sum;
	};

	static int CalculateSum(int[,] arr, int startX, int startY, int endX, int endY)
	{
		int sum = 0;
		for (int i = startY; i < endY; ++i)
		{
			for (int j = startX; j < endX; ++j)
			{
				sum += arr[i, j];
			}
		}
		return sum;
	}
	static max_sum FindMaxSumMatrix(int[,] arr)
	{
		max_sum max = new max_sum();
		max.sum = int.MinValue;
		int currentSum;
		for (int i = 0; i < arr.GetLength(0) - 2; ++i)
		{
			for (int j = 0; j < arr.GetLength(1) - 2; ++j)
			{
				currentSum = CalculateSum(arr, j, i, j + 3, i + 3);
				if (currentSum > max.sum)
				{
					max.posX = j;
					max.posY = i;
					max.sum = currentSum;
				}
			}
		}
		return max;
	}

	static void Main(string[] args)
	{
		string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		int n = int.Parse( input[ 0 ] ),
			m = int.Parse( input[ 1 ] );
		int[,] matrix = new int[n, m];

		for (int i = 0; i < n; ++i)
		{
			input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			for (int j = 0; j < m; ++j)
			{
				matrix[i, j] = int.Parse(input[j]);
			}
		}

		max_sum max = FindMaxSumMatrix(matrix);

		Console.WriteLine("Sum = {0}", max.sum);
		for (int i = 0; i < 3; ++i)
		{
			for (int j = 0; j < 3; ++j)
			{
				Console.Write("{0} ", matrix[max.posY + i, max.posX + j]);
			}
			Console.WriteLine();
		}
	}
}
/*
4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4
*/