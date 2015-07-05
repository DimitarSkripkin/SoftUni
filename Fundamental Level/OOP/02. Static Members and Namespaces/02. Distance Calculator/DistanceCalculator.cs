using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _02.Distance_Calculator
{
	static class DistanceCalculator
	{
		public static float CalculateDistance(Point3D p1, Point3D p2)
		{
			return (float)Math.Sqrt(
				(p1.X - p2.X) * (p1.X - p2.X)
				+ (p1.Y - p2.Y) * (p1.Y - p2.Y)
				+ (p1.Z - p2.Z) * (p1.Z - p2.Z));
		}
	}
}
