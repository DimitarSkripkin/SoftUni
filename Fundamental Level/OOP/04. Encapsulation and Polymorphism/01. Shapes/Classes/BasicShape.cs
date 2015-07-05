using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
	public abstract class BasicShape : IShape
	{
		private double width, height;

		protected BasicShape( double width, double height )
		{
			this.Width = width;
			this.Height = height;
		}

		public double Width
		{
			get
			{
				return this.width;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("width can't be negative");
				}
				this.width = value;
			}
		}
		public double Height
		{
			get
			{
				return this.height;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("height can't be negative");
				}
				this.height = value;
			}
		}

		public abstract double CalculateArea();

		public abstract double CalculatePerimeter();
	}
}
