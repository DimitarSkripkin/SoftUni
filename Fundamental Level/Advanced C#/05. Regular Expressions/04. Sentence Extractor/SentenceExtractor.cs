using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SentenceExtractor
{
	static void Main(string[] args)
	{
		string word = Console.ReadLine();
		string pattern = string.Format(@"(\w[\w\s]+\b{0}|^{0})\b[^.!?]*[.!?]", word);
		string input = Console.ReadLine();

		var regex = new Regex(pattern);//,RegexOptions.IgnoreCase);
		var sentences = regex.Matches(input);

		for (int i = 0; i < sentences.Count; ++i)
		{
			Console.WriteLine(sentences[i]);
		}
	}
}