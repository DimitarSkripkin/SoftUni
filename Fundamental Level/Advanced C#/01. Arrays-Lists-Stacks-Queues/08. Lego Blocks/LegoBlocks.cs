using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LegoBlocks {
	static void Main( string[] args ) {
		int rowsCount = int.Parse( Console.ReadLine() );
		List<int>[] leftPart = new List<int>[ rowsCount ];
		List<int>[] rightPart = new List<int>[ rowsCount ];
		char[] separator = { ' ' };

		int cellCount = 0;
		for ( int i = 0; i < rowsCount; ++i ) {
			leftPart[ i ] = Console.ReadLine()
				.Split( separator, StringSplitOptions.RemoveEmptyEntries )
				.Select( int.Parse )
				.ToList();

			cellCount += leftPart[ i ].Count;
		}
		for ( int i = 0; i < rowsCount; ++i ) {
			rightPart[ i ] = Console.ReadLine()
				.Split( separator, StringSplitOptions.RemoveEmptyEntries )
				.Select( int.Parse )
				.ToArray()
				.Reverse()
				.ToList();

			cellCount += rightPart[ i ].Count;
		}

		int rowSize = leftPart[ 0 ].Count + rightPart[ 0 ].Count;
		for ( int i = 1; i < rowsCount; ++i ) {
			if ( rowSize != ( leftPart[ i ].Count + rightPart[ i ].Count ) ) {
				rowSize = -1;
				break;
			}
		}

		if ( rowSize < 0 ) {
			Console.WriteLine( "The total number of cells is: {0}", cellCount );
		} else {
			for ( int i = 0; i < rowsCount; ++i ) {
				Console.WriteLine( "[{0}, {1}]",
					string.Join( ", ", leftPart[ i ] ),
					string.Join( ", ", rightPart[ i ] )
				);
			}
		}
	}
}