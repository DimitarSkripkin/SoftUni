using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Root
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int number = int.Parse(Console.ReadLine());
				if (number < 0)
				{
					throw new ArgumentException("number must be positive");
				}

				double sqrtNumber = Math.Sqrt(number);
				Console.WriteLine(sqrtNumber);
			}
			catch (OverflowException)
			{
				Console.WriteLine("Invalid number");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Invalid number");
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid number");
			}
			finally
			{
				Console.WriteLine("Good bye");
			}
		}
	}
}