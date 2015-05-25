using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine();

		int maxLen = input.Length < 20 ? input.Length : 20;
		string output = input.Substring(0, maxLen).PadRight(20, '*');

		Console.WriteLine(output);
	}
}