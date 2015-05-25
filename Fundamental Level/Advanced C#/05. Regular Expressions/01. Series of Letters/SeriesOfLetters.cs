using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SeriesOfLetters
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine(),
			pattern = @"(\w)(?=\1)";

		string output = Regex.Replace(input, pattern, "");
		Console.WriteLine(output);

		//string pattern = @"(\w)(?!\1)";
		//Regex regex = new Regex(pattern);
		//MatchCollection consecutiveLetters = regex.Matches(input);
		//for (int i = 0; i < consecutiveLetters.Count; ++i)
		//{
		//	Console.Write(consecutiveLetters[i]);
		//}
		//Console.WriteLine();
		//Console.WriteLine(string.Join("",consecutiveLetters));
	}
}