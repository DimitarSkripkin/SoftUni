using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class WordCount
{
	static void Main(string[] args)
	{
		const string wordsFineName = "../../words.txt";
		const string textFileName = "../../text.txt";
		const string resultFileName = "../../result.txt";

		var words = new SortedList<string,int>();

		using (var sr = new StreamReader(wordsFineName))
		{
			string line = sr.ReadLine();
			while (line != null)
			{
				if (!words.ContainsKey(line))
				{
					words[line] = 0;
				}
				line = sr.ReadLine();
			}
		}

		using (var sr = new StreamReader(textFileName))
		{
			string line = sr.ReadLine();
			while (line != null)
			{
				foreach( var word in words.Keys.ToArray())
				{
					words[word] += Regex.Matches(line, word).Count;
				}
				line = sr.ReadLine();
			}
		}

		using (var sw = new StreamWriter(resultFileName))
		{
			var resultList = words.OrderByDescending(p => p.Value).ToList();
			for (int i = 0; i < resultList.Count; ++i)
			{
				sw.WriteLine("{0} - {1}", resultList[i].Key, resultList[i].Value);
			}
		}
	}
}