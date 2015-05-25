//Write a method that reverses the digits of a given floating-point number.
using System;
using System.Linq;
using System.Threading;

class ReverseNumber
{
	static double GetReversedNumber(double n)
	{
		if (n < 0)
		{
			return -double.Parse(string.Join("", (-n).ToString().Reverse()));
		}
		else
		{
			return double.Parse(string.Join("", n.ToString().Reverse()));
		}

		//double result;
		//if ( n < 0 ) {
		//	result = -double.Parse( string.Join( "", ( -n ).ToString().Reverse() ) );
		//} else {
		//	result = double.Parse(string.Join("", n.ToString().Reverse()));
		//}
		//return result;
	}

	//static double GetReversedNumberABS( double n ) {
	//	double result = double.Parse( string.Join( "", Math.Abs( n ).ToString().Reverse() ) );
	//	if ( n < 0 ) {
	//		return -result;
	//	}
	//	return result;
	//}

	static public void Main(string[] args)
	{
		Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
		double number = double.Parse(Console.ReadLine());

		number = GetReversedNumber(number);
		Console.WriteLine(number);

		//number = GetReversedNumberABS( number );
		//Console.WriteLine( number );
	}
}