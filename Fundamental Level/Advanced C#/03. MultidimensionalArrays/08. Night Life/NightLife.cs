using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NightLife
{
	static void Main(string[] args)
	{
		var events = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
		//var events = new SortedList<string, int>();//SortedSet<string>;
		//List<KeyValuePair<string, int>> list;// = events.ToList();//List<KeyValuePair<string, int>>()

		string[] input = Console.ReadLine().Split(';');
		string city, venue, performer;
		while (input[0] != "END")
		{
			city = input[0];
			venue = input[1];
			performer = input[2];

			if (!events.ContainsKey(city))
			{
				events[city] = new SortedDictionary<string, SortedSet<string>>();
			}
			if (!events[city].ContainsKey(venue))
			{
				events[city][venue] = new SortedSet<string>();
			}

			events[city][venue].Add(performer);
			input = Console.ReadLine().Split(';');
		}

		foreach (var c in events.Keys)
		{
			Console.WriteLine(c);
			foreach (var v in events[c].Keys)
			{
				Console.WriteLine("->{0}: {1}", v, string.Join(", ", events[c][v]));
			}
		}
	}
}