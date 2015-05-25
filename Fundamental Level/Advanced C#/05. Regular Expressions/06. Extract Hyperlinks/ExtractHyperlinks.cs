using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
	static void Main(string[] args)
	{
		var inputList = new List<string>();

		string input = Console.ReadLine();
		while (input != "END")
		{
			inputList.Add(input);
			input = Console.ReadLine();
		}

		string text = string.Join("\n", inputList),
			pattern = @"<\s*a[=""'()\s\w]+href\s*=\s*('(?'hl'[^']+)'|""(?'hl'[^""]+)""|(?'hl'[^>]+))[^>]*>";
		var regex = new Regex(pattern);

		var matches = regex.Matches(text);

		for (int i = 0; i < matches.Count; ++i)
		{
			Console.WriteLine(matches[i].Groups["hl"]);
		}
	}
}