using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine();

		Dictionary<char, int> dictionary = new Dictionary<char, int>();
		foreach (char c in input)
		{
			if (!dictionary.ContainsKey(c))
			{
				dictionary[c] = 0;
			}
			dictionary[c] += 1;
		}

		List<char> sortedKeys = dictionary.Keys.ToList();
		sortedKeys.Sort();

		foreach (char key in sortedKeys)
		{
			Console.WriteLine("{0}: {1} time/s", key, dictionary[key]);
		}
	}
}