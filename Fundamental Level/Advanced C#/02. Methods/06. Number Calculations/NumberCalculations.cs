/*
Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers.
Overload the methods to work with numbers of type double and decimal.
Note: Do not use LINQ.
*/
using System;
using System.Threading;

class NumberCalculations
{
	// Minimum
	static double GetMin(double[] arr)
	{
		double min = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			if (arr[i] < min)
			{
				min = arr[i];
			}
		}
		return min;
	}

	static decimal GetMin(decimal[] arr)
	{
		decimal min = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			if (arr[i] < min)
			{
				min = arr[i];
			}
		}
		return min;
	}

	// Maximum
	static double GetMax(double[] arr)
	{
		double max = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			if (arr[i] > max)
			{
				max = arr[i];
			}
		}
		return max;
	}

	static decimal GetMax(decimal[] arr)
	{
		decimal max = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			if (arr[i] > max)
			{
				max = arr[i];
			}
		}
		return max;
	}

	// Average
	static double GetAverage(double[] arr)
	{
		return GetSum(arr) / arr.Length;
	}

	static decimal GetAverage(decimal[] arr)
	{
		return GetSum(arr) / arr.Length;
	}

	// Sum
	static double GetSum(double[] arr)
	{
		double sum = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			sum += arr[i];
		}
		return sum;
	}

	static decimal GetSum(decimal[] arr)
	{
		decimal sum = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			sum += arr[i];
		}
		return sum;
	}

	// Product
	static double GetProduct(double[] arr)
	{
		double product = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			product *= arr[i];
		}
		return product;
	}

	static decimal GetProduct(decimal[] arr)
	{
		decimal product = arr[0];
		for (int i = 1; i < arr.Length; ++i)
		{
			product *= arr[i];
		}
		return product;
	}

	static void Main(string[] args)
	{
		Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

		double[] arrDouble = { 2.3, 5.6, 1, -3, 0.1 };
		Console.WriteLine("min: {0}", GetMin(arrDouble));
		Console.WriteLine("max: {0}", GetMax(arrDouble));
		Console.WriteLine("sum: {0}", GetSum(arrDouble));
		Console.WriteLine("average: {0}", GetAverage(arrDouble));
		Console.WriteLine("product: {0}", GetProduct(arrDouble));

		Console.WriteLine();

		double[] arrDecimal = { 2.3, 5.6, 1, -3, 0.1 };
		Console.WriteLine("min: {0}", GetMin(arrDecimal));
		Console.WriteLine("max: {0}", GetMax(arrDecimal));
		Console.WriteLine("sum: {0}", GetSum(arrDecimal));
		Console.WriteLine("average: {0}", GetAverage(arrDecimal));
		Console.WriteLine("product: {0}", GetProduct(arrDecimal));
	}
}