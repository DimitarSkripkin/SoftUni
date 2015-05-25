/*
Write a program to read an array of numbers from the console, sort them and print them back on the console.
The numbers should be entered from the console on a single line, separated by a space. Examples:
Input				Output
6 5 4 10 -3 120 4	-3 4 4 5 6 10 120
10 9 8				8 9 10
*/
using System;
using System.Linq;

class SortArrayOfNumbers {
	static void Main( string[] args ) {
		int[] numbers = Console.ReadLine()
			.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
			.Select( int.Parse )
			.ToArray();
		//Console.WriteLine( string.Join( " ", numbers ) );

		Array.Sort( numbers );

		Console.WriteLine( string.Join( " ", numbers ) );

		//Console.WriteLine(
		//	string.Join( " ",
		//		Console.ReadLine()
		//			.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
		//			.Select( int.Parse )
		//			.OrderBy( p => -p )
		//	)
		//);
	}
}