using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Phonebook
{
	static void Main(string[] args)
	{
		var phonebook = new Dictionary<string, List<string>>();

		string[] input = Console.ReadLine().Split('-');
		string command = input[0];
		while (command != "search")
		{
			if (!phonebook.ContainsKey(input[0]))
			{
				phonebook[input[0]] = new List<string>();
			}
			phonebook[input[0]].Add(input[1]);

			input = Console.ReadLine().Split('-');
			command = input[0];
		}

		Console.WriteLine();
		command = Console.ReadLine();
		while (command != "end")
		{
			if (!phonebook.ContainsKey(command))
			{
				Console.WriteLine("Contact {0} does not exist.", command);
			}
			else
			{
				Console.WriteLine("{0} -> {1}", command, string.Join(", ", phonebook[command]));
			}
			command = Console.ReadLine();
		}
	}
}