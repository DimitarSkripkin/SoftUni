using System;
using System.IO;

class OddLines
{
	static void Main(string[] args)
	{
		const string fileName = "../../text.txt";

		using (var sr = new StreamReader(fileName))
		{
			string line = sr.ReadLine();
			bool isOdd = true;
			while (line != null)
			{
				if (isOdd)
				{
					Console.WriteLine(line);
					isOdd = false;
				}
				else
				{
					isOdd = true;
				}

				line = sr.ReadLine();
			}
		}
	}
}