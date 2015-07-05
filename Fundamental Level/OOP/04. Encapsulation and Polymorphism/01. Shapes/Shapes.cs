using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
	class Shapes
	{
		static void Main(string[] args)
		{
			var list = new List<IShape>()
			{
				new Circle(3),
				new Rectangle(3, 4),
				new Triangle(3, 4)
			};

			foreach (var item in list)
			{
				Console.WriteLine("area: {0}, perimeter: {1}", item.CalculateArea(), item.CalculatePerimeter());
			}
		}
	}
}
