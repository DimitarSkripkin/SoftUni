/*
Write a method that returns the index of the first element in array that is larger than its neighbours,
or -1 if there's no such element. Use the method from the previous exercise in order to re.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
	static bool IsLargerThenNeighbours(int[] arr, int index)
	{
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

	static int GetIndexOfFirstElementLargerThanNeighbours(int[] arr)
	{
		for (int i = 0; i < arr.Length; ++i)
		{
			if (IsLargerThenNeighbours(arr, i))
			{
				return i;
			}
		}
		return -1;
	}

	static void Main(string[] args)
	{
		//int[] sequenceOne = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
		int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
		int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
		int[] sequenceThree = { 1, 1, };

		Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
		Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
		Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
	}
}