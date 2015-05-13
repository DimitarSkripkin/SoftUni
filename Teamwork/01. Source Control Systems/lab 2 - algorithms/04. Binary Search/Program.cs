using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_Search {
	class Program {
		static int BinarySearch( int[] arr, int value ) {
			int lIndex = 0, rIndex = arr.Length - 1;

			while ( lIndex <= rIndex ) {
				int midPoint = ( lIndex + rIndex ) / 2;

				if ( arr[ midPoint ] == value ) {
					return midPoint;
				}
				if ( value > arr[ midPoint ] ) {
					lIndex = midPoint + 1;
				} else {
					rIndex = midPoint - 1;
				}
			}
			return -1;
		}

		static int LinearSearch( int[] arr, int value ) {
			for ( int i = 0; i < arr.Length; ++i ) {
				if ( arr[ i ] == value ) {
					return i;
				}
			}
			return -1;
		}

		static void Main( string[] args ) {
			int[] numbers = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
			//Array.Sort( numbers );
			int value = int.Parse( Console.ReadLine() );

			int atPosBin = BinarySearch( numbers, value );
			int atPosLinear = LinearSearch( numbers, value );

			Console.WriteLine( atPosBin );
			Console.WriteLine( atPosLinear );
			//Console.WriteLine( "value {0} at pos {1}", value, atPos );
		}
	}
}
