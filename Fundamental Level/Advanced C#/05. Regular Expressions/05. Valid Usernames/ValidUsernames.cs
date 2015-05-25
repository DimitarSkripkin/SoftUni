using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ValidUsernames
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine();
		string pattern = @"\b[a-zA-Z]\w{2,24}\b";
		var regex = new Regex(pattern);
		var matches = regex.Matches(input);

		int bestLenght = 0, firstIndex = 0, secondIndex = 1,
			currentLenght;
		for (int i = 0; i < matches.Count - 1; ++i)
		{
			currentLenght = matches[i].Length + matches[i + 1].Length;
			if (bestLenght < currentLenght)
			{
				firstIndex = i;
				secondIndex = i + 1;
				bestLenght = currentLenght;
			}
		}

		Console.WriteLine(matches[firstIndex]);
		Console.WriteLine(matches[secondIndex]);
	}
}