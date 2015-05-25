using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FullDirectoryTraversal
{
	static void TraverseDirectory_r(string dir, StreamWriter fileToWrite, int printOffset)
	{
		string[] subdirectories = Directory.GetDirectories(dir);

		string line = string.Format("{0}{1}", new string(' ', printOffset), dir);
		fileToWrite.WriteLine(line);
		Console.WriteLine(line);

		foreach (var subdir in subdirectories)
		{
			TraverseDirectory_r(subdir, fileToWrite, printOffset + 1);
		}

		TraverseDirectory(dir, fileToWrite, printOffset + 1);
	}

	static void TraverseDirectory(string dir, StreamWriter fileToWrite, int printOffset)
	{
		var fileList = Directory.GetFiles(dir).Select(p => new FileInfo(p)).ToList();
		var groupedByExtention = fileList
			.GroupBy(p => p.Extension)
			.OrderByDescending(p => p.Count())
			.ThenBy(p => p.Key)
			.ToList();
		for (int i = 0; i < groupedByExtention.Count; ++i)
		{
			var currentGroup = groupedByExtention[i]
				.OrderByDescending(p => p.Length)
				.ToArray();

			string line = string.Format("{0}{1}", new string(' ', printOffset), currentGroup[0].Extension);
			fileToWrite.WriteLine(line);
			Console.WriteLine(line);
			foreach (var file in currentGroup)
			{
				line = string.Format("{0}--{1} - {2:0.000}kb", new string(' ', printOffset), file.Name, file.Length / 1024.0);
				fileToWrite.WriteLine(line);
				Console.WriteLine(line);
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
			TraverseDirectory_r(directoryToTraverse, sw, 0);
		}
	}
}