using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public class Developer : RegularEmployee, IDeveloper
	{
		private HashSet<Project> projects;

		public Developer(string firsName, string lastName, int id, decimal salary, IList<Project> projects)
			: base(firsName, lastName, id, salary, Department.Production)
		{
			this.projects = new HashSet<Project>(projects);
		}

		public ISet<Project> Projects
		{
			get
			{
				return this.projects;
			}
		}

		public void AddProjects(ISet<Project> projects)
		{
			this.projects.UnionWith(projects);
		}

		public override string ToString()
		{
			StringBuilder toReturn = new StringBuilder(string.Format("{0}\nprojects\n",base.ToString()));
			foreach (var project in projects)
			{
				toReturn.AppendLine(project.ToString());
			}
			return toReturn.ToString();
		}
	}
}
