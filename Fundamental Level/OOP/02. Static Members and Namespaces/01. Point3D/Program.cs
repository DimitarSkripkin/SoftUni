using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
	class Point
	{
		static void Main(string[] args)
		{
			Point3D p = new Point3D(0, 1, 0);
			Console.WriteLine(p);
			p = Point3D.StartingPoint;
			p.X = 5;
			Console.WriteLine(p);
			Console.WriteLine(Point3D.StartingPoint);
		}
	}
}
