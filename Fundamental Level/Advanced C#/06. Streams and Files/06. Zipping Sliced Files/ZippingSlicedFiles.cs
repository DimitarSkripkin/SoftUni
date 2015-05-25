using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

class ZippingSlicedFiles
{
	static void Slice(string SourceFile, string destinationDirectory, int parts)
	{
		using (var readStream = new FileStream(SourceFile, FileMode.Open))
		{
			string fileName = destinationDirectory + "/" + Regex.Match(SourceFile, @".*(\/|\\)(?'filename'.+)$").Groups["filename"];

			byte[] fileBuffer = new byte[readStream.Length / parts + readStream.Length % parts];
			int lenght, part = 0;
			while (true)
			{
				lenght = readStream.Read(fileBuffer, 0, fileBuffer.Length);

				if (lenght == 0)
				{
					break;
				}

				++part;
				using (var writeStream = new FileStream(fileName + "." + part + ".gz", FileMode.OpenOrCreate))
				{
					using (var writeCompressedStream = new GZipStream(writeStream, CompressionMode.Compress))
					{
						writeCompressedStream.Write(fileBuffer, 0, lenght);
					}
				}
			}
		}
	}

	static void Assemble(List<string> files, string destinationDirectory)
	{
		string fileName = destinationDirectory + "/" + Regex.Match(files[0], @".*(\/|\\)(?'filename'.+)\.\d+\.gz$").Groups["filename"];

		using (var writeStream = new FileStream(fileName, FileMode.OpenOrCreate))
		{
			foreach (var file in files)
			{
				using (var readStream = new FileStream(file, FileMode.Open))
				{
					using (var readCompressedStream = new GZipStream(readStream, CompressionMode.Decompress))
					{
						byte[] buffer = new byte[0x1000];
						while (true)
						{
							int lenght = readCompressedStream.Read(buffer, 0, buffer.Length);
							if (lenght == 0)
							{
								break;
							}
							writeStream.Write(buffer, 0, lenght);
						}
					}
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
			destinationFolder + "/picture.jpg.1.gz",
			destinationFolder + "/picture.jpg.2.gz",
			destinationFolder + "/picture.jpg.3.gz",
			destinationFolder + "/picture.jpg.4.gz",
			destinationFolder + "/picture.jpg.5.gz"
		};
		Assemble(list, destinationFolder);
	}
}