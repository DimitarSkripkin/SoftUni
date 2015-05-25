using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine();

		StringBuilder output = new StringBuilder();
		for (int i = 0; i < input.Length; ++i)
		{
			output.Append("\\u" + ((int)input[i]).ToString("X4"));
		}
		//StringBuilder output = new StringBuilder(
		//	string.Join("\\u", input.Select(p => ((int)p).ToString("X4")))
		//	);
		//output.Insert(0, "\\u");

		Console.WriteLine(output);
	}
}