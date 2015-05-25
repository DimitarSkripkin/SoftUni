/*
Write a program that reads an array of strings and finds in it all sequences of
equal elements (comparison should be case-sensitive). The input strings are given as a single line,
separated by a space. Examples:
Input						Output
hi yes yes yes				bye	hi
							yes yes yes
							bye
SoftUni softUni softuni		SoftUni
							softUni
							softuni
1 1 2 2 3 3 4 4 5 5			1 1
							2 2
							3 3
							4 4
							5 5
a b b xxx c c c				a
							b b
							xxx
							c c c
hi hi hi hi hi				hi hi hi hi hi
hello						hello
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequencesOfEqualStrings {
	struct item {
		public List<string> strList;
	};

	static void Main( string[] args ) {
		var sequences = new List<item>();
		item lastItem = new item();

		string[] input = Console.ReadLine().Split( ' ' );
		lastItem.strList = new List<string>() {
			input[ 0 ]
		};

		for ( int i = 1; i < input.Length; ++i ) {
			if ( !lastItem.strList[ 0 ].Equals( input[ i ], StringComparison.OrdinalIgnoreCase ) ) {
				sequences.Add( lastItem );

				lastItem = new item();
				lastItem.strList = new List<string>();
			}
			lastItem.strList.Add( input[ i ] );

			if ( i == input.Length - 1 ) {
				sequences.Add( lastItem );
			}
		}

		foreach ( var s in sequences ) {
			foreach ( var str in s.strList ) {
				Console.Write( str + " " );
			}
			Console.WriteLine();
		}
	}
}