using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	public enum Status
	{
		Open,
		Closed
	}

	interface IProject
	{
		string Name { get; set; }
		DateTime StartDate { get; }
		string Details { get; set; }
		Status State { get; }
		void CloseProject();
		string ToString();
	}
}
