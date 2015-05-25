using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
	static bool IsPalindrome(string str)
	{
		int maxLen = str.Length/2,
			j = str.Length - 1;
		for (int i = 0; i < maxLen; ++i)
		{
			if (str[i] != str[j])
			{
				return false;
			}
			--j;
		}
		return true;
	}

	static string ReturnAllPalindroms(string str, char[] textDividers, string resultDivider)
	{
		string[] words = str
			.Split(textDividers, StringSplitOptions.RemoveEmptyEntries)
			.ToArray();

		var outputList = new SortedSet<string>();
		for (int i = 0; i < words.Length; ++i)
		{
			if (IsPalindrome(words[i]))
			{
				outputList.Add(words[i]);
			}
		}

		return string.Join(resultDivider, outputList);
	}

	static void Main(string[] args)
	{
		//string[] input = Console.ReadLine()
		//	.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
		//	.ToArray();

		//var outputList = new SortedSet<string>();
		//for (int i = 0; i < input.Length; ++i)
		//{
		//	if (IsPalindrome(input[i]))
		//	{
		//		outputList.Add(input[i]);
		//	}
		//}

		//Console.WriteLine(string.Join(", ", outputList));

		string input = Console.ReadLine(),
			output = ReturnAllPalindroms(input, new[] { ' ', ',', '.', '?', '!' }, ", ");

		Console.WriteLine(output);
	}
}