using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortedSubsetSums {
	static bool IsActiveBit( ulong number, int bit ) {
		return ( ( number >> bit ) & 0x1 ) > 0;
	}

	static int GetNumberOfActiveBits( ulong number ) {
		int toReturn = 0;
		while ( number > 0 ) {
			if ( ( number & 1 ) == 1 ) {
				++toReturn;
			}
			number /= 2;
		}
		return toReturn;
	}

	struct line {
		public string str;
		public int firstNumber;
	};

	static void Main( string[] args ) {
		int subsetSum = int.Parse( Console.ReadLine() );
		int[] input = Console.ReadLine()
			.Split( ' ' )
			.Select( int.Parse )
			.Distinct()
			.ToArray();
		ulong maxMask = ( (ulong)1 << input.Length );

		Dictionary<int, List<line>> output = new Dictionary<int, List<line>>();
		line toOutput;
		for ( ulong mask = 1; mask < maxMask; ++mask ) {
			int currentSum = 0;

			for ( int j = 0; j < input.Length; ++j ) {
				if ( IsActiveBit( mask, j ) ) {
					currentSum += input[ j ];
				}
			}

			if ( currentSum == subsetSum ) {
				toOutput = new line();

				bool isFirst = true;
				for ( int j = 0; j < input.Length; ++j ) {
					if ( IsActiveBit( mask, j ) ) {
						toOutput.str += input[ j ].ToString() + " + ";

						if ( isFirst ) {
							toOutput.firstNumber = input[ j ];
							isFirst = false;
						}
					}
				}

				toOutput.str = toOutput.str.TrimEnd( new char[] { ' ', '+' } );
				int key = GetNumberOfActiveBits( mask );

				if ( !output.ContainsKey( key ) ) {
					output[ GetNumberOfActiveBits( mask ) ] = new List<line>();
				}
				output[ GetNumberOfActiveBits( mask ) ].Add( toOutput );
			}
		}

		if ( output.Count == 0 ) {
			Console.WriteLine( "No matching subsets." );
		} else {
			foreach ( List<line> list in output.Values ) {
				list.Sort( ( a, b ) => a.firstNumber.CompareTo( b.firstNumber ) );
				foreach ( line l in list ) {
					Console.WriteLine( "{0} = {1}", l.str, subsetSum );
				}
			}
		}
	}
}