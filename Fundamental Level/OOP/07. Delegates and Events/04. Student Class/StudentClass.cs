using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Student_Class
{
	class StudentClass
	{
		static void Main(string[] args)
		{
			Student student = new Student("Peter", 0, 22);

			student.PropertyChanged += (sender, eventArgs) =>
			{
				Console.WriteLine("Property changed: {0} (from {1} to {2})",
					eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
			};

			student.Name = "Maria";
			student.Age = 19;
		}
	}
}
