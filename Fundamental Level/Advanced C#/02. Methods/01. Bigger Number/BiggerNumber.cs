/*
Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().
Input	Output
 4		4
-5
*/

using System;

class BiggerNumber
{
	static int GetMax(int a, int b)
	{
		if (a < b)
		{
			return b;
		}
		return a;
	}

	static void Main(string[] args)
	{
		int firstNumber = int.Parse(Console.ReadLine()),
			secondNumber = int.Parse(Console.ReadLine()),
			max = GetMax(firstNumber, secondNumber);

		Console.WriteLine(max);
	}
}