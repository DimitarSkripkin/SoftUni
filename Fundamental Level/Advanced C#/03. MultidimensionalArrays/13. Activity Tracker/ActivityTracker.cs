using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ActivityTracker
{
	static void Main(string[] args)
	{
		int size = int.Parse(Console.ReadLine());

		SortedDictionary<byte, SortedList<string,float>> users = new SortedDictionary<byte, SortedList<string,float>>();
		for (int i = 0; i < size; ++i)
		{
			string[] inputLine = Console.ReadLine().Split(' ');

			byte month = byte.Parse(inputLine[0].Split('/')[1]);
			string userName = inputLine[1];
			float distance = float.Parse(inputLine[2]);

			if (!users.Keys.Contains(month))
			{
				users[month] = new SortedList<string,float>();
			}
			if (!users[month].Keys.Contains(userName))
			{
				users[month][userName] = 0.0f;
			}

			users[month][userName] += distance;
		}

		StringBuilder output = new StringBuilder();
		foreach (var month in users.Keys)
		{
			output.AppendFormat("{0}: ", month);
			foreach (var user in users[month].Keys)
			{
				output.AppendFormat("{0}({1}), ", user, users[month][user]);
			}
			output.Remove(output.Length - 2, 2);
			output.Append('\n');

		}

		Console.WriteLine(output.ToString());
	}
}