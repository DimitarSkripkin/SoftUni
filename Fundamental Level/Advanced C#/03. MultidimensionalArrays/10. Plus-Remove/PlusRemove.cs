using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlusRemove
{
	static void Main(string[] args)
	{
		List<string> input = new List<string>();
		List<char[]> output = new List<char[]>();

		string line = Console.ReadLine();
		while (line != "END")
		{
			input.Add(line.ToLower());
			output.Add(line.ToArray());

			line = Console.ReadLine();
		}

		for (int i = 0; i < input.Count - 2; ++i)
		{
			int maxLenght = Math.Min(input[i].Length, Math.Min(input[i + 1].Length - 1, input[i + 2].Length));

			for (int j = 1; j < maxLenght; ++j)
			{
				char first = input[i][j],
					second = input[i + 1][j - 1],
					third = input[i + 1][j],
					forth = input[i + 1][j + 1],
					fifth = input[i + 2][j];

				if (first == second && second == third && third == forth && forth == fifth)
				{
					output[i][j] = '\0';
					output[i + 1][j - 1] = '\0';
					output[i + 1][j] = '\0';
					output[i + 1][j + 1] = '\0';
					output[i + 2][j] = '\0';
				}
			}
		}

		foreach (var arr in output)
		{
			//foreach (var c in arr)
			//{
			//	if (c != '\0')
			//	{
			//		Console.Write(c);
			//	}
			//}
			//Console.WriteLine();
			Console.WriteLine(string.Join("", arr));
		}
	}
}
