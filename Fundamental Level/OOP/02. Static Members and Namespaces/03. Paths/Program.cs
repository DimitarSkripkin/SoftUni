using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
	class Program
	{
		const string fileToLoad = "../../path.txt";
		const string fileToSave = "../../savedPath.txt";

		static void Main(string[] args)
		{
			Path3D path = Storage.LoadPath(fileToLoad);

			path.AddPoint(new Point3D(0, 0, 0));
			path.AddPoint(new Point3D(1, 0, 0));
			path.AddPoint(new Point3D(2, 0, 0));
			path.AddPoint(new Point3D(3, 0, 0));

			Path3D copy = new Path3D(path);

			path.AddPoint(new Point3D(4, 0, 0));

			copy.AddPoints(new Point3D[]{
				new Point3D(0,1,0),
				new Point3D(0,2,0)
			});

			Storage.SavePath(fileToSave, copy);

			Console.WriteLine(path);
			Console.WriteLine(copy);
		}
	}
}
