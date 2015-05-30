using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceInMatrix
{
	static int GetLenghtOfTheLongestSequenceInGivenDirection(string[,] arr, int row, int col, int rowStep, int colStep )
	{
		int maxLenght = 0,
			atRow = row + rowStep,
			atCol = col + colStep;

		while (true)
		{

			if (colStep != 0 && !(atCol >= 0 && atCol < arr.GetLength(1)))
			{
				break;
			}
			if (rowStep != 0 && !(atRow >= 0 && atRow < arr.GetLength(0)))
			{
				break;
			}

			if (arr[atRow, atCol] == arr[row, col])
			{
				++maxLenght;
			}
			else
			{
				break;
			}
			atRow += rowStep;
			atCol += colStep;
		}

		return maxLenght;
	}

	static int GetLenghtOfTheLongestSequence(string[,] arr, int row, int col)
	{
		int maxLenght = 1, tempLen = 1;

		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, 0, 1);
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, 0, -1);
		maxLenght = tempLen;

		tempLen = 1;
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, 1, 0);
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, -1, 0);
		if (tempLen > maxLenght)
		{
			maxLenght = tempLen;
		}

		tempLen = 1;
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, 1, 1);
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, -1, -1);
		if (tempLen > maxLenght)
		{
			maxLenght = tempLen;
		}

		tempLen = 1;
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, 1, -1);
		tempLen += GetLenghtOfTheLongestSequenceInGivenDirection(arr, row, col, -1, 1);
		if (tempLen > maxLenght)
		{
			maxLenght = tempLen;
		}

		return maxLenght;
	}
/*test
5 6
ha fifi ho hi e hi
fo ha ha hi xx dsa
xxx ho ha xx s hi
s s qq p m ho
d a xx e ha he

3 4
ha fifi ho hi
fo ha hi xx
xxx ho ha xx

3 3
s qq s
pp pp s
pp qq s
*/
	static void Main(string[] args)
	{
		// set matrix
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

		// find longest sequence
		int longestSequence = 0,
			currentSequence;
		string longestSequenceStr = "";

		for (int i = 0; i < matrix.GetLength(0); ++i)
		{
			for (int j = 0; j < matrix.GetLength(1); ++j)
			{
				currentSequence = GetLenghtOfTheLongestSequence(matrix, i, j);

				if (currentSequence > longestSequence)
				{
					longestSequence = currentSequence;
					longestSequenceStr = matrix[i, j];
				}
			}
		}

		// print longest sequence
		Console.WriteLine();
		for (int i = 0; i < longestSequence; ++i)
		{
			if (i + 1 < longestSequence)
			{
				Console.Write("{0}, ", longestSequenceStr);
			}
			else
			{
				Console.WriteLine(longestSequenceStr);
			}
		}
	}
}