using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Insertion_Sort {
	class Program {
		static void Main( string[] args ) {
			int[] numbers = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

			for ( int i = 1; i < numbers.Length; ++i ) {
				int j = i;
				while ( j > 0 && numbers[ j - 1 ] > numbers[ j ] ) {
					int temp = numbers[ j - 1 ];
					numbers[ j - 1 ] = numbers[ j ];
					numbers[ j ] = temp;
					--j;
				}
			}

			Console.WriteLine( string.Join( " ", numbers ) );
		}
	}
}