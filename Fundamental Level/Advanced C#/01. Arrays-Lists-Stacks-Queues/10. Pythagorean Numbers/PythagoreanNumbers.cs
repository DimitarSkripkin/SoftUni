using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PythagoreanNumbers {
	static bool IsValidSet( int a, int b, int c ) {
		return a <= b && ( ( a * a + b * b ) == c * c );
	}
	static void Main( string[] args ) {
		int numberCount = int.Parse( Console.ReadLine() );

		int[] numbers = new int[ numberCount ];
		for ( int i = 0; i < numberCount; ++i ) {
			numbers[ i ] = int.Parse( Console.ReadLine() );
		}

		bool foundNumbers = false;

		for ( int n1 = 0; n1 < numberCount; ++n1 ) {
			for ( int n2 = 0; n2 < numberCount; ++n2 ) {
				for ( int n3 = 0; n3 < numberCount; ++n3 ) {
					if ( IsValidSet( numbers[ n1 ], numbers[ n2 ], numbers[ n3 ] ) ) {
						Console.WriteLine( "{0}*{0} + {1}*{1} = {2}*{2}",
							numbers[ n1 ], numbers[ n2 ], numbers[ n3 ] );
						foundNumbers = true;
					}
				}
			}
		}

		if ( !foundNumbers ) {
			Console.WriteLine( "No" );
		}
	}
}