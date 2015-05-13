using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.The_Sieve_of_Eratosthenes {
	class Program {
		static bool IsPrime( int number ) {
			int lastToCheck = (int)Math.Sqrt(number);
			for ( int i = 2; i <= lastToCheck; ++i ) {
				if ( number % i == 0 ) {
					return false;
				}
			}
			return true;
		}
		static void Main( string[] args ) {
			int n = int.Parse( Console.ReadLine() );
			var list = new List<int>();
			for ( int i = 2; i < n; ++i ) {
				if ( IsPrime( i ) ) {
					list.Add( i );
				}
			}
			Console.WriteLine( string.Join( ", ", list ) );
		}
	}
}
