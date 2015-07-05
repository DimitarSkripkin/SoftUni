using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
	class Path3D
	{
		private List<Point3D> points;

		public List<Point3D> Points
		{
			get
			{
				//return points;
				return new List<Point3D>(points);
			}
		}

		public void AddPoint(Point3D point)
		{
			points.Add(point);
			//points.Add(new Point3D(point));
		}

		public void AddPoints(Point3D[] points)
		{
			this.points.AddRange(points);
		}

		public void RemovePointAt(int index)
		{
			points.RemoveAt(index);
		}

		public Path3D()
		{
			this.points = new List<Point3D>();
		}

		public Path3D(Path3D other)
		{
			this.points = new List<Point3D>(other.points);
		}

		public override string ToString()
		{
			StringBuilder toReturn = new StringBuilder("Path\n");
			for (int i = 0; i < points.Count; ++i)
			{
				toReturn.AppendFormat("point {0} at {1}\n", i, points[i]);
			}
			//toReturn.Remove(toReturn.Length - 1, 1);
			return toReturn.ToString();
		}
	}
}
