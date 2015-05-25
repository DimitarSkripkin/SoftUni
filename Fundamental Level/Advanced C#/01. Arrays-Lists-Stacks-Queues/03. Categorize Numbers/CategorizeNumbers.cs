/*
Write a program that reads N floating-point numbers from the console.
Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.)
and the other containing the floating-point numbers with non-zero fraction.
Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).
Examples:
Input													Output
1.2 -4 5.00 12211 93.003 4 2.2		[1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum: 96.403, avg: 32.13
									[-4, 5, 12211, 4] - > min: -4, max: 12211, sum: 12216, avg: 3054.00
*/
using System;
using System.Linq;
using System.Threading;
//using System.Collections;
using System.Collections.Generic;

class CategorizeNumbers {
	static void Main( string[] args ) {
		Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
		List<float> input = Console.ReadLine()
			.Split( ' ' )
			.Select( float.Parse )
			.ToList();

		float[] roundNumbers = input.FindAll( p => p == (int)p ).ToArray();
		float[] notRoundNumbers = input.FindAll( p => p != (int)p ).ToArray();

		Console.WriteLine( "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}",
			string.Join( ", ", notRoundNumbers ), notRoundNumbers.Min(), notRoundNumbers.Max(), notRoundNumbers.Sum(), notRoundNumbers.Average() );

		Console.WriteLine( "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}",
			string.Join( ", ", roundNumbers ), roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average() );
	}
}