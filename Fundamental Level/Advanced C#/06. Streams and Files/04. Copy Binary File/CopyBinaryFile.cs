using System.IO;

class CopyBinaryFile
{
	static void Main(string[] args)
	{
		const string copyFrom = "../../sea-coast-night-sky-stars-milky-way-wide.jpg";
		const string copyTo = "../../copy.jpg";

		using (var fsRead = new FileStream(copyFrom, FileMode.Open))
		{
			using (var fsWrite = new FileStream(copyTo, FileMode.Create))
			{
				var buffer = new byte[0x1000];
				int lenght;
				while (true)
				{
					lenght = fsRead.Read(buffer, 0, buffer.Length);

					if (lenght == 0)
					{
						break;
					}

					fsWrite.Write(buffer, 0, lenght);
				}
			}
		}
	}
}