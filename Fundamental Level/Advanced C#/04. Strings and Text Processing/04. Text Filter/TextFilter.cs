﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextFilter
{
	static void Main(string[] args)
	{
		string[] bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
		string text = Console.ReadLine();

		for (int i = 0; i < bannedWords.Length; ++i)
		{
			text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
		}

		Console.WriteLine(text);
	}
}