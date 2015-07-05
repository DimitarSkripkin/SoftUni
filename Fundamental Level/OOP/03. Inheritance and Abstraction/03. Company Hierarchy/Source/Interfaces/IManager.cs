using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	using Classes;

	interface IManager
	{
		ISet<Employee> Employees { get; }
		void AddEmployees(ISet<Employee> employees);
		string ToString();
	}
}
