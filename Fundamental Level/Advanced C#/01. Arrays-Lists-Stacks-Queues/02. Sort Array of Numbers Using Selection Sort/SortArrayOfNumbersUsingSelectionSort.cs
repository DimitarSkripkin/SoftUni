/*
Write a program to sort an array of numbers and then print them back on the console.
The numbers should be entered from the console on a single line, separated by a space.
Refer to the examples for problem 1.
Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.
*/
using System;
using System.Linq;

class SortArrayOfNumbers {
	static void Swap<T>( ref T lhs, ref T rhs ) {
		T temp = lhs;
		lhs = rhs;
		rhs = temp;
	}

	static void SelectionSort( int[] arr ) {
		int i, j, min;
		for ( i = 0; i < arr.Length - 1; ++i ) {
			min = i;
			for ( j = i + 1; j < arr.Length; ++j ) {
				if ( arr[ j ] < arr[ min ] ) {
					min = j;
				}
			}

			if ( min != i ) {
				Swap( ref arr[ i ], ref arr[ min ] );
			}
		}
	}
	//static void SelectionSort( int[] arr ) {
	//	int i, j, max;
	//	for ( i = 0; i < arr.Length - 1; ++i ) {
	//		max = i;
	//		for ( j = i + 1; j < arr.Length; ++j ) {
	//			if ( arr[ j ] > arr[ max ] ) {
	//				max = j;
	//			}
	//		}

	//		if ( max != i ) {
	//			Swap( ref arr[ i ], ref arr[ max ] );
	//		}
	//	}
	//}

	static void Main( string[] args ) {
		int[] numbers = Console.ReadLine()
			.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
			.Select( int.Parse )
			.ToArray();
		//Console.WriteLine( string.Join( " ", numbers ) );

		SelectionSort( numbers );

		Console.WriteLine( string.Join( " ", numbers ) );
	}
}