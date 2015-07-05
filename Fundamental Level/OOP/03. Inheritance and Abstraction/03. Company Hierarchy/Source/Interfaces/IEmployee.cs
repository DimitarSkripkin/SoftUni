using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	public enum Department
	{
		Production,
		Accounting,
		Sales,
		Marketing
	}

	interface IEmployee
	{
		decimal Salary { get; set; }
		Department Department { get; set; }
		string ToString();
	}
}
