using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Olympics_Are_Coming
{
	class Program
	{
		class Country
		{
			public SortedSet<string> athleets;
			public int wins;

			public Country()
			{
				athleets = new SortedSet<string>();
				wins = 0;
			}
		}
		static void Main(string[] args)
		{
			Regex regex = new Regex("\\s+");
			var countries = new Dictionary<string, Country>();

			string[] input = Console.ReadLine().Split('|');
			while (input[0] != "report")
			{
				input[0] = regex.Replace(input[0], " ").Trim();
				input[1] = regex.Replace(input[1], " ").Trim();

				if (!countries.Keys.Contains(input[1]))
				{
					Country add = new Country();
					countries[input[1]] = add;
				}

				Country val;
				countries.TryGetValue(input[1], out val);
				val.athleets.Add(input[0]);
				++val.wins;

				input = Console.ReadLine().Split('|');
			}

			foreach (var pair in countries.OrderByDescending(p => p.Value.wins))
			{
				Console.WriteLine("{0} ({1} participants): {2} wins", pair.Key, countries[pair.Key].athleets.Count, countries[pair.Key].wins);
			}
		}
	}
}
