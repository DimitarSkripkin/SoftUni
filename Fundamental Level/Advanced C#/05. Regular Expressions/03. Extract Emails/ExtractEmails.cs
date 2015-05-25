using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine();
		string pattern = @"((?<=\s)|^)[a-zA-Z0-9][\w-.]+[a-zA-Z0-9]@[a-zA-Z][\w-.]+\.[a-zA-Z]+";
		var regex = new Regex(pattern);

		MatchCollection emails = regex.Matches(input);

		for (int i = 0; i < emails.Count; ++i)
		{
			Console.WriteLine(emails[i]);
		}
	}
}