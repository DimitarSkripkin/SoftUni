/*
Write a method that returns the last digit of a given integer as an English word.
Test the method with different input values.
Ensure you name the method properly.
*/
using System;

class LastDigitOfNumber
{
	static string GetLastDigitAsWord(int a)
	{
		if (a < 0)
		{
			a = -a;
		}
		a %= 10;

		string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
		return digits[a];
	}

	static void Main(string[] args)
	{
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine(GetLastDigitAsWord(number));
	}
}