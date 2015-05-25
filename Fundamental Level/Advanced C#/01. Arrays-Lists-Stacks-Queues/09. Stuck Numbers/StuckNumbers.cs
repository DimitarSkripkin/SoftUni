using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StuckNumbers {
	static int FastJoin( int a, int b ) {// dobaveno zaradi judge sitemata
		if ( b / 1000 > 0 ) {
			return a * 10000 + b;
		} else if ( b / 100 > 0 ) {
			return a * 1000 + b;
		} else if ( b / 10 > 0 ) {
			return a * 100 + b;
		}
		return a * 10 + b;
	}

	static bool IsValidSet( int a, int b, int c, int d ) {
		return ( a != b && a != c && a != d 
			&& c != d
			&& b != c && b != d
			//&& ( "" + a + b ).Equals( "" + c + d )
			// be6e prekaleno bavno za judge sitemata sravnenie sus stringove na poslednite 3 testa :)
			&& a != 0 && c != 0
			&& FastJoin( a, b ) == FastJoin( c, d )
		);
	}

	static void Main( string[] args ) {
		int numbersCount = int.Parse( Console.ReadLine() );
		// ima6e problem na 5ti test s
		// int[] numbers = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
		int[] numbers = new int[ numbersCount ];
		string[] input = Console.ReadLine().Split( ' ' );
		for ( int i = 0; i < numbersCount; ++i ) {
			numbers[ i ] = int.Parse( input[ i ] );
		}

		int foundSet = 0;
		for ( int n1 = 0; n1 < numbersCount; ++n1 ) {
			for ( int n2 = 0; n2 < numbersCount; ++n2 ) {
				for ( int n3 = 0; n3 < numbersCount; ++n3 ) {
					for ( int n4 = 0; n4 < numbersCount; ++n4 ) {
						if ( IsValidSet( numbers[ n1 ], numbers[ n2 ], numbers[ n3 ], numbers[ n4 ] ) ) {
							Console.WriteLine( "{0}|{1}=={2}|{3}",
								numbers[ n1 ], numbers[ n2 ], numbers[ n3 ], numbers[ n4 ] );
							++foundSet;
						}
					}
				}
			}
		}

		if ( foundSet == 0 ) {
			Console.WriteLine( "No" );
		}
	}
}