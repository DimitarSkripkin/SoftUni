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
			//List<int> arr = Enumerable.Range( 2, n - 1 ).ToList();

			//int p = 2;
			//while ( p < n ) {
			//	for ( int i = 0; i < n - 1; ++i ) {
			//		if ( arr[ i ] % p == 0 && arr[i] != p ) {
			//			arr[ i ] = -1;
			//		}
			//	}
			//	++p;
			//}
			//arr.RemoveAll( item => item == -1 );
			//Console.WriteLine(string.Join(", ",arr));
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
