/*
Write a program to find all increasing sequences inside an array of integers.
The integers are given on a single line, separated by a space. Print the sequences in the order
of their appearance in the input array, each at a single line. Separate the sequence elements by a space.
Find also the longest increasing sequence and print it at the last line.
If several sequences have the same longest length, print the left-most of them. Examples:
Input					Output
2 3 4 1 50 2 3 4 5		2 3 4
						1 50
						2 3 4 5
						Longest: 2 3 4 5
8 9 9 9 -1 5 2 3		8 9
						9
						9
						-1 5
						2 3
						Longest: 8 9
1 2 3 4 5 6 7 8 9		1 2 3 4 5 6 7 8 9
						Longest: 1 2 3 4 5 6 7 8 9
5 -1 10 20 3 4			5
						-1 10 20
						3 4
						Longest: -1 10 20
10 9 8 7 6 5 4 3 2 1	10
						9
						8
						7
						6
						5
						4
						3
						2
						1
						Longest: 10
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncreasingSequence
{
	static void Main(string[] args)
	{
		int[] input = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToArray();

		List<int> longestSequence = new List<int>(),
			currentSequence = new List<int>();
		var sequences = new List<List<int>>();

		//currentSequence.Add(input[0]);
		//for (int i = 1; i < input.Length; ++i)
		//{
		//	if (currentSequence.LastOrDefault() >= input[i])
		//	{
		//		sequences.Add(new List<int>(currentSequence));

		//		if (longestSequence.Count < currentSequence.Count)
		//		{
		//			longestSequence = currentSequence;
		//			currentSequence = new List<int>();
		//		}
		//		currentSequence.Clear();
		//	}

		//	currentSequence.Add(input[i]);
		//}

		//sequences.Add(currentSequence);
		//if (longestSequence.Count < currentSequence.Count)
		//{
		//	longestSequence = currentSequence;
		//}

		currentSequence.Add(input[0]);
		for (int i = 1; i < input.Length; ++i)
		{
			if (currentSequence.LastOrDefault() >= input[i])
			{
				sequences.Add(new List<int>(currentSequence));
				currentSequence.Clear();
			}
			currentSequence.Add(input[i]);
		}
		sequences.Add(currentSequence);
		longestSequence = sequences.Aggregate( (a,b) => a.Count > b.Count ? a : b );

		foreach (var sequence in sequences)
		{
			Console.WriteLine(string.Join(" ", sequence));
		}
		Console.WriteLine("Longesr: {0}", string.Join(" ", longestSequence));
	}
}