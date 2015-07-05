using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _02.Distance_Calculator
{
	class Distance
	{
		static void Main(string[] args)
		{
			Point3D p1 = new Point3D(2, 0, 0),
				p2 = new Point3D(0, 0, 0);

			Console.WriteLine("distance between {0} and {1} is {2}",
				p1, p2, DistanceCalculator.CalculateDistance(p1, p2));
		}
	}
}
