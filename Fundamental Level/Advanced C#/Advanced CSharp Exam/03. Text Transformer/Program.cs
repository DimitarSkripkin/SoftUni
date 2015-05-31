using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Text_Transformer
{
	class Program
	{
		static StringBuilder ProcessMatch(string match)
		{
			StringBuilder result = new StringBuilder(match);

			int specialSymbolWeght = 1;
			switch (result[result.Length - 1])
			{
				case '$':
					specialSymbolWeght = 1;
					break;
				case '%':
					specialSymbolWeght = 2;
					break;
				case '&':
					specialSymbolWeght = 3;
					break;
				case '\'':
					specialSymbolWeght = 4;
					break;
			}
			result.Remove(result.Length - 1, 1);
			for (int i = 0; i < result.Length; ++i)
			{
				if (i % 2 == 0)
				{
					result[i] += (char)specialSymbolWeght;
				}
				else
				{
					result[i] -= (char)specialSymbolWeght;
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			//const string pattern = @"([$%&'])([^$%&']+\1)";
			const string pattern = @"(\$|%|&|')([^$%&']+\1)";
			StringBuilder inputOutputSB = new StringBuilder();

			string inputLine = Console.ReadLine();
			while (inputLine != "burp")
			{
				inputOutputSB.Append(inputLine);
				inputLine = Console.ReadLine();
			}

			string inputText = Regex.Replace(inputOutputSB.ToString(), "\\s+", " ");
			Regex regex = new Regex(pattern);

			MatchCollection matches = regex.Matches(inputText);

			inputOutputSB.Clear();
			foreach (Match match in matches)
			{
				inputOutputSB.AppendFormat("{0} ", ProcessMatch(match.Groups[2].Value));
			}

			Console.WriteLine(inputOutputSB.ToString());
		}
	}
}
