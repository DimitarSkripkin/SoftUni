using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TerroristsWin
{
	static int CalculateSum(char[] arr, int leftIndex, int rightIndex)
	{
		if (rightIndex > arr.Length)
		{
			rightIndex = arr.Length;
		}

		int sum = 0;
		for (int i = leftIndex; i < rightIndex; ++i)
		{
			sum += arr[i];
		}
		return sum % 10;
	}

	static void SetCharAtRange(char[] arr, char c, int leftIndex, int rightIndex)
	{
		if (leftIndex < 0)
		{
			leftIndex = 0;
		}
		if (rightIndex > arr.Length)
		{
			rightIndex = arr.Length;
		}

		for (int i = leftIndex; i < rightIndex; ++i)
		{
			arr[i] = c;
		}
	}

	static void Main(string[] args)
	{
		int bufferSize = 1024;
		Stream inStream = Console.OpenStandardInput(bufferSize);
		Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufferSize));

		string input = Console.ReadLine();

		int leftIndex = input.IndexOf('|'),
			rightIndex = input.IndexOf('|', leftIndex + 1);

		char[] blownMap = input.ToArray();
		while (leftIndex >= 0)
		{
			if (rightIndex < 0)
			{
				rightIndex = blownMap.Length;
			}
			int power = CalculateSum(blownMap, leftIndex + 1, rightIndex);
			SetCharAtRange(blownMap, '.', leftIndex - power, rightIndex + power + 1);

			leftIndex = input.IndexOf('|', rightIndex + 1);
			rightIndex = input.IndexOf('|', leftIndex + 1);
		}

		Console.WriteLine(string.Join("", blownMap));
	}
}