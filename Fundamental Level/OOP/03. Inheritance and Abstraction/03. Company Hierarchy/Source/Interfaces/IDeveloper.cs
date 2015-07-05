using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	using Classes;

	interface IDeveloper
	{
		ISet<Project> Projects { get; }
		void AddProjects(ISet<Project> projects);
		string ToString();
	}
}
