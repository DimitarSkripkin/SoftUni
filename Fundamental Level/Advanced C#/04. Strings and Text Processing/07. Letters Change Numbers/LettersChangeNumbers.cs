using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersChangeNumbers
{
	static void Main(string[] args)
	{
		string[] input = Console.ReadLine()
			.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
			.ToArray();

		double sum = 0;
		for (int i = 0; i < input.Length; ++i)
		{
			double number = double.Parse(input[i].Substring(1, input[i].Length - 2));
			char leftLetter = input[i][0],
				rightLetter = input[i][input[i].Length - 1];

			if (char.IsLower(leftLetter))
			{
				number *= leftLetter - 'a' + 1;
			}
			else
			{
				number /= leftLetter - 'A' + 1;
			}

			if (char.IsLower(rightLetter))
			{
				number += rightLetter - 'a' + 1;
			}
			else
			{
				number -= rightLetter - 'A' + 1;
			}

			sum += number;
		}

		Console.WriteLine("{0:F2}", sum);
	}
}