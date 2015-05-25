using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DirectoryTraversal
{
	static void TraverseDirectory(string dir, StreamWriter fileToWrite)
	{
		var fileList = Directory.GetFiles(dir).Select(p => new FileInfo(p)).ToList();
		var groupedByExtention = fileList
			.GroupBy(p => p.Extension)
			.OrderByDescending(p=>p.Count())
			.ThenBy(p=>p.Key)
			.ToList();
		for (int i = 0; i < groupedByExtention.Count; ++i)
		{
			var currentGroup = groupedByExtention[i]
				.OrderByDescending(p=>p.Length)
				.ToArray();

			fileToWrite.WriteLine(currentGroup[0].Extension);
			Console.WriteLine(currentGroup[0].Extension);
			foreach (var file in currentGroup)
			{
				fileToWrite.WriteLine("--{0} - {1:0.000}kb", file.Name, file.Length / 1024.0);
				Console.WriteLine("--{0} - {1:0.000}kb", file.Name, file.Length / 1024.0);
			}
		}
	}

	static void Main(string[] args)
	{
		string directoryToTraverse = "../../";
		//string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string desktop = directoryToTraverse;

		using (var sw = new StreamWriter(desktop + "/report.txt"))
		{
			TraverseDirectory(directoryToTraverse, sw);
		}
	}
}