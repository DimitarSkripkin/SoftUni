using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Command_Interpreter
{
	class Program
	{
		static void Reverse(string[] arr, int start, int count)
		{
			int last = start + count - 1;
			while (start < last)
			{
				string temp = arr[start];
				arr[start] = arr[last];
				arr[last] = temp;

				++start;
				--last;
			}
			//Array.Reverse(arr, start, count);
		}

		static void Sort(string[] arr, int start, int count)
		{
			Array.Sort(arr, start, count);
		}

		static void RollLeft(string[] arr, int count)
		{
			count %= arr.Length;
			for (int i = 0; i < count; ++i)
			{
				string first = arr[0];
				for (int j = 0; j < arr.Length - 1; ++j)
				{
					arr[j] = arr[j + 1];
				}
				arr[arr.Length - 1] = first;
			}
		}

		static void RollRight(string[] arr, int count)
		{
			count %= arr.Length;
			for (int i = 0; i < count; ++i)
			{
				string last = arr[arr.Length - 1];
				for (int j = arr.Length - 1; j > 0; --j)
				{
					arr[j] = arr[j - 1];
				}
				arr[0] = last;
			}
		}

		static bool CheckIsValidInput(string[] input, int start, ref int count)
		{
			//if (start < 0 || count < 0 || start >= input.Length || count > input.Length) //85
			if (start < 0 || count < 0 || start >= input.Length || count > input.Length || (long)start + (long)count > input.Length)
			{
				Console.WriteLine("Invalid input parameters.");
				return false;
			}
			return true;
		}

		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int count, start;
			while (command[0] != "end")
			{
				switch (command[0])
				{
					case "reverse":
						start = int.Parse(command[2]);
						count = int.Parse(command[4]);
						if (CheckIsValidInput(input, start, ref count))
						{
							Reverse(input, start, count);
						}
						break;
					case "sort":
						start = int.Parse(command[2]);
						count = int.Parse(command[4]);
						if (CheckIsValidInput(input, start, ref count))
						{
							Sort(input, start, count);
						}
						break;
					case "rollLeft":
						count = int.Parse(command[1]);
						if (count < 0)
						{
							Console.WriteLine("Invalid input parameters.");
							break;
						}
						RollLeft(input, count);
						break;
					case "rollRight":
						count = int.Parse(command[1]);
						if (count < 0)
						{
							Console.WriteLine("Invalid input parameters.");
							break;
						}
						RollRight(input, count);
						break;
					default:
						throw new System.ArgumentException("nema takova jivotno ?");
				}

				command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}

			Console.WriteLine("[{0}]",string.Join(", ",input));
		}
	}
}
