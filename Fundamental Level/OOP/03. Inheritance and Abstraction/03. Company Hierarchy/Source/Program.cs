using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
	using Classes;
	using Interfaces;

	class Program
	{
		static void Main(string[] args)
		{
			IProject project = new Project("zz", new DateTime(2015, 06, 15), "nqma", Status.Open);
			Console.WriteLine(project);
			Console.WriteLine();

			IList<Project> projects = new List<Project>()
			{
				new Project("z1", new DateTime(2015, 06, 15), "nqma", Status.Open),
				new Project("z2", new DateTime(2015, 06, 15), "nqma", Status.Open),
				new Project("z3", new DateTime(2015, 06, 15), "nqma", Status.Open)
			};

			projects[1].CloseProject();

			var developer = new Developer("pesho", "peshov", 5, 5m, projects);

			Console.WriteLine(developer);
			Console.WriteLine();

			var sales = new List<Sale>()
			{
				new Sale("tigan",DateTime.Now,20m)
			};
			IList<Employee> employees = new List<Employee>()
			{
				developer,
				new SalesEmployee("mariika","gotinata",50,50m,sales)
			};

			IManager manager = new Manager("pesho", "shevcheto", 6, 20m, Department.Marketing, employees);
			Console.WriteLine(manager);
		}
	}
}
