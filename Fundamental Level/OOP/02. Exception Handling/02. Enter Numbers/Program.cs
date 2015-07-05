using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_Numbers
{
	class Program
	{
		static int ReadNUmber(int start, int end)
		{
			int number = int.Parse(Console.ReadLine());
			if (number < start || number > end)
			{
				throw new ArgumentException(string.Format("number have to be in range [{0}..{1}]", start, end));
			}
			return number;
		}

		static void Main(string[] args)
		{
			int[] arr = new int[10];

			for (int i = 0; i < arr.Length; ++i)
			{
				int start = Math.Max(1, arr.Max()) + 1;
				int end = ( 100 - arr.Length ) + i;

				while (true)
				{
					try
					{
						arr[i] = ReadNUmber(start, end);
						break;
					}
					catch (OverflowException)
					{
						Console.WriteLine("number is too big, enter new number");
					}
					catch (ArgumentException e)
					{
						Console.WriteLine(e.Message);
					}
					catch (FormatException)
					{
						Console.WriteLine("please enter integer number");
					}
				}
			}

			Console.WriteLine("numbers");
			Console.WriteLine(string.Join(" < ", arr));
		}
	}
}
