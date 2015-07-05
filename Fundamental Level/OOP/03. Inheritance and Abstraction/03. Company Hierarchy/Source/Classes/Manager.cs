using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public class Manager : Employee, IManager
	{
		HashSet<Employee> employees;

		public Manager(string firsName, string lastName, int id, decimal salary, Department department, IList<Employee> employees)
			: base(firsName, lastName, id, salary, department)
		{
			this.employees = new HashSet<Employee>(employees);
		}

		public ISet<Employee> Employees
		{
			get
			{
				return this.employees;
			}
		}

		public void AddEmployees(ISet<Employee> employees)
		{
			this.employees.UnionWith(employees);
		}

		public override string ToString()
		{
			StringBuilder toReturn = new StringBuilder(string.Format("Manager {0}\n",base.ToString()));
			foreach (var employee in employees)
			{
				toReturn.AppendLine(string.Format("employee {0}", employee.ToString()));
			}
			return toReturn.ToString();
		}
	}
}
