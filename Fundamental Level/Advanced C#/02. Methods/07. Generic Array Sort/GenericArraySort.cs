using System;
using System.Collections.Generic;
using System.Threading;

class GenericArraySort
{
	static void Swap<T>(ref T lhs, ref T rhs)
	{
		T temp = lhs;
		lhs = rhs;
		rhs = temp;
	}

	static void SelectionSort<T>(T[] arr)
	{
		int i, j, min;
		for (i = 0; i < arr.Length - 1; ++i)
		{
			min = i;
			for (j = i + 1; j < arr.Length; ++j)
			{
				if (Comparer<T>.Default.Compare(arr[j], arr[min]) < 0)
				{
					min = j;
				}
			}

			if (min != i)
			{
				Swap(ref arr[i], ref arr[min]);
			}
		}
	}

	static void Main(string[] args)
	{
		Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

		int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
		string[] strings = { "zaz", "cba", "baa", "azis" };
		DateTime[] dates = {
			new DateTime( 2002, 3, 1 ), new DateTime( 2015, 5, 6 ), new DateTime( 2014, 1, 1 )
		};

		SelectionSort(numbers);
		SelectionSort(strings);
		SelectionSort(dates);

		Console.WriteLine(string.Join(" ", numbers));
		Console.WriteLine(string.Join(" ", strings));
		Console.WriteLine(string.Join(" ", dates));
	}
}