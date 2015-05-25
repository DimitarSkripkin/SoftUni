using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prime_Factorization {
	class Program {
		static void Main( string[] args ) {
			var primeSet = new List<int>();

			int number = int.Parse( Console.ReadLine() ),
				numberCopy = number;
			int currentDivider = 2;
			while ( number > 0
				&& number != currentDivider ) {

				if ( number % currentDivider == 0 ) {
					primeSet.Add( currentDivider );
					number /= currentDivider;
				} else {
					if ( currentDivider % 2 == 1 ) {
						currentDivider += 2;
					} else {
						++currentDivider;
					}
				}
			}
			primeSet.Add( currentDivider );

			Console.WriteLine( "{0} = {1}", numberCopy, string.Join( " * ", primeSet ) );
		}
	}
}