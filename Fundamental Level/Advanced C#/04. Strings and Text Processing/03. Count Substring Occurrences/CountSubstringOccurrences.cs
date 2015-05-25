using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstringOccurrences
{
	static void Main(string[] args)
	{
		string input = Console.ReadLine();
		string toCount = Console.ReadLine();
		int count = 0;

		//int maxLenght = input.Length - toCount.Length + 1;
		//input = input.ToLower();
		//toCount = toCount.ToLower();
		//for (int i = 0; i < maxLenght; ++i)
		//{
		//	int j = 0;
		//	while (j < toCount.Length && input[i + j] == toCount[j])
		//	{
		//		++j;
		//	}

		//	if (j == toCount.Length)
		//	{
		//		++count;
		//	}
		//}

		int atIndex = 0;
		while (true)
		{
			atIndex = input.IndexOf(toCount, atIndex,StringComparison.InvariantCultureIgnoreCase);
			if (atIndex >= 0)
			{
				++count;
				++atIndex;
			}
			else
			{
				break;
			}
		}

		Console.WriteLine(count);
	}
}