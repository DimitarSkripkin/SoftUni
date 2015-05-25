/*
 Write a method that checks if the element at given position in a given array of integers
 is larger than its two neighbours (when such exist).
 */
using System;
using System.Linq;

class LargerThanNeighbours
{
	static bool IsLargerThenNeighbours(int[] arr, int index)
	{
		//if (index < 0 || index >= arr.Length)
		//{
		//	return false;
		//}

		if (index == 0)
		{
			return arr[index] > arr[index + 1];
		}
		else if (index == arr.Length - 1)
		{
			return arr[index] > arr[index - 1];
		}
		return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
	}

	static void Main(string[] args)
	{
		//int[] numbers = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
		int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

		for (int i = 0; i < numbers.Length; ++i)
		{
			Console.WriteLine(IsLargerThenNeighbours(numbers, i));
		}
	}
}