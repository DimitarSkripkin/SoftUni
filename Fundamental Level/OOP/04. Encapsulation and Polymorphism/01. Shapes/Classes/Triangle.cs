using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
	public class Triangle : BasicShape
	{
		public Triangle(double width, double height)
			: base(width, height)
		{
		}

		public override double CalculateArea()
		{
			return (this.Width * this.Height) / 2.0;
		}

		public override double CalculatePerimeter()
		{
			double c = Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height));
			return this.Width + this.Height + c;
		}
	}
}
