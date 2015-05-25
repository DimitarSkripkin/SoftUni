using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceTag
{
	static void Main(string[] args)
	{
		string input = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
		//string input = Console.ReadLine();

		string pattern1 = @"<a href=([\w:./-]+)>", pattern2 = @"</a>";
		string replace1 = "[URL href=$1]", replace2 = "[/URL]";

		string output = Regex.Replace(input, pattern2, replace2);
		output = Regex.Replace(output, pattern1, replace1);
		
		Console.WriteLine(output);

		Console.WriteLine();
		string pattern = @"<a href=([\w:./-]+)>(.+)</a>",
			replace = @"[URL href=$1]$2[/URL]";
		output = Regex.Replace(input, pattern, replace);
		Console.WriteLine(output);
	}
}