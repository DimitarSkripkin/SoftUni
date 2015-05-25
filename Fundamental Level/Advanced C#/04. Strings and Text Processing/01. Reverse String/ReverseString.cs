using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
	static string GetReversedString(string str)
	{
		return new string( str.Reverse().ToArray() );
	}
	static void Main(string[] args)
	{
		string input = Console.ReadLine();
		Console.WriteLine(GetReversedString(input));
	}
}