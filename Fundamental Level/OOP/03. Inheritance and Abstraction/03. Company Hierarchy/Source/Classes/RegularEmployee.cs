using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public abstract class RegularEmployee : Employee
	{
		protected RegularEmployee(string firsName, string lastName, int id, decimal salary, Department department)
			: base(firsName, lastName, id, salary, department)
		{
		}
	}
}
