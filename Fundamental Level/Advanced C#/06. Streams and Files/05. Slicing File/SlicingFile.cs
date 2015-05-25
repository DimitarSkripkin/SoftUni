using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class SlicingFile
{
	static void Slice(string SourceFile, string destinationDirectory, int parts)
	{
		using (var fsRead = new FileStream(SourceFile, FileMode.Open))
		{
			string fileName = destinationDirectory + "/" + Regex.Match(SourceFile, @".*(\/|\\)(?'filename'.+)$").Groups["filename"];

			byte[] fileBuffer = new byte[fsRead.Length / parts + fsRead.Length % parts];
			int lenght, part = 0;
			while (true)
			{
				lenght = fsRead.Read(fileBuffer, 0, fileBuffer.Length);

				if (lenght == 0)
				{
					break;
				}

				++part;
				using (var fsWrite = new FileStream(fileName + "." + part, FileMode.OpenOrCreate))
				{
					fsWrite.Write(fileBuffer, 0, lenght);
				}
			}
		}
	}

	static void Assemble(List<string> files, string destinationDirectory)
	{
		string fileName = destinationDirectory + "/" + Regex.Match(files[0], @".*(\/|\\)(?'filename'.+)\.\d+$").Groups["filename"];

		using (var fsWrite = new FileStream(fileName, FileMode.OpenOrCreate))
		{
			foreach (var file in files)
			{
				using (var fsRead = new FileStream(file, FileMode.Open))
				{
					byte[] buffer = new byte[fsRead.Length];
					fsRead.Read(buffer, 0, buffer.Length);
					fsWrite.Write(buffer, 0, buffer.Length);
				}
			}
		}
	}

	static void Main(string[] args)
	{
		const string sourceFile = "../../picture.jpg";
		const string destinationFolder = "../../IO";

		Slice(sourceFile, destinationFolder, 5);

		var list = new List<string>{
			destinationFolder + "/picture.jpg.1",
			destinationFolder + "/picture.jpg.2",
			destinationFolder + "/picture.jpg.3",
			destinationFolder + "/picture.jpg.4",
			destinationFolder + "/picture.jpg.5"
		};
		Assemble(list, destinationFolder);
	}
}