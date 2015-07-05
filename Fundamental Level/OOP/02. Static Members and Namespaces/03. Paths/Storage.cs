using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
	static class Storage
	{
		public static Path3D LoadPath(string file)
		{
			Path3D path = new Path3D();

			using (StreamReader reader = new StreamReader(file))
			{
				while (true)
				{
					string line = reader.ReadLine();

					if (line == null)
					{
						break;
					}

					float[] coord = line
						.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries)
						.Select(float.Parse)
						.ToArray();
					path.AddPoint(new Point3D(coord[0], coord[1], coord[2]));
				}
			}

			return path;
		}

		public static void SavePath(string file, Path3D path)
		{
			using (StreamWriter writer = new StreamWriter(file))
			{
				foreach(var point in path.Points)
				{
					writer.WriteLine(string.Format("{0} {1} {2}",
						point.X, point.Y, point.Z));
				}
			}
		}
	}
}
