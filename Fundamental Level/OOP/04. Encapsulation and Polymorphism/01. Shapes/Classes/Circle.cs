using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
	public class Circle : IShape
	{
		private double radius;

		public Circle(double radius)
		{
			this.Radius = radius;
		}

		public double Radius
		{
			get
			{
				return this.radius;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("radius can't be negative");
				}
				this.radius = value;
			}
		}

		public double CalculateArea()
		{
			return Math.PI * this.Radius * this.Radius;
		}

		public double CalculatePerimeter()
		{
			return 2.0 * Math.PI * this.Radius;
		}
	}
}
