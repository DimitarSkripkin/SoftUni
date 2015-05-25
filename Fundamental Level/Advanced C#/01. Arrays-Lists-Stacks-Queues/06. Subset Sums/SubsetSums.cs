/*
Write a program that reads from the console a number N and an array of integers given on a single line.
Your task is to find all subsets within the array which have a sum equal to N
and print them on the console (the order of printing is not important).
Find only the unique subsets by filtering out repeating numbers first.
In case there aren't any subsets with the desired sum, print "No matching subsets." Examples:
Input						Output
11
0 11 1 10 5 6 3 4 7 2		0 + 11 = 11
							11 = 11
							1 + 10 = 11
							0 + 1 + 10 = 11
							5 + 6 = 11
							0 + 5 + 6 = 11
							1 + 6 + 4 = 11
							0 + 1 + 6 + 4 = 11
							1 + 3 + 7 = 11
							0 + 1 + 3 + 7 = 11
							4 + 7 = 11
							0 + 7 + 4 = 11
							1 + 5 + 3 + 2 = 11
							0 + 1 + 5 + 3 + 2 = 11
							6 + 3 + 2 = 11
							0 + 6 + 3 + 2 = 11
							5 + 4 + 2 = 11
							0 + 5 + 4 + 2 = 11

0
1 2 3 4 5					No matching subsets.

-2
-5 4 92 0 928 1 -1 4		-5 + 4 + -1 = -2
							-5 + 4 + 0 + -1 = -2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetSums
{
	static bool IsActiveBit(ulong number, int bit)
	{
		return ((number >> bit) & 0x1) > 0;
	}

	static void Main(string[] args)
	{
		int subsetSum = int.Parse(Console.ReadLine());
		int[] input = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.Distinct()
			.ToArray();
		ulong maxMask = ((ulong)1 << input.Length);

		string output = "";
		for (ulong mask = 1; mask < maxMask; ++mask)
		{
			int currentSum = 0;

			for (int j = 0; j < input.Length; ++j)
			{
				if (IsActiveBit(mask, j))
				{
					currentSum += input[j];
				}
			}

			if (currentSum == subsetSum)
			{
				output = "";

				for (int j = 0; j < input.Length; ++j)
				{
					if (IsActiveBit(mask, j))
					{
						output += input[j].ToString() + " + ";
					}
				}

				output = output.TrimEnd(new char[] { ' ', '+' });
				Console.WriteLine("{0} = {1}", output, subsetSum);
			}
		}

		if (output == "")
		{
			Console.WriteLine("No matching subsets.");
		}
	}
}