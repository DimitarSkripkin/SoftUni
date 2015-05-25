using System.IO;

class LineNumbers
{
	static void Main(string[] args)
	{
		const string readingFileName = "../../text.txt";
		const string writingFileName = "../../result.txt";

		using (var sr = new StreamReader(readingFileName))
		{
			using (var sw = new StreamWriter(writingFileName))
			{
				string line = sr.ReadLine();
				int lineNumber = 0;
				while (line!=null)
				{
					sw.WriteLine("{0,3} {1}", lineNumber, line);
					++lineNumber;
					line = sr.ReadLine();
				}
			}
		}
	}
}