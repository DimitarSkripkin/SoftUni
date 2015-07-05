using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
	public class Point3D
	{
		private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }

		public static Point3D StartingPoint
		{
			get
			{
				return new Point3D( startingPoint );
			}
		}

		public Point3D()
			: this(startingPoint)
		{
		}

		public Point3D(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public Point3D(Point3D other)
			: this(other.X, other.Y, other.Z)
		{
		}

		public override string ToString()
		{
			return string.Format("({0},{1},{2})", X, Y, Z);
		}
	}
}
