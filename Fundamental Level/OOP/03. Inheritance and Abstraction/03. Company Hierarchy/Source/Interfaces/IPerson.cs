using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	interface IPerson
	{
		int ID { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string ToString();
	}
}
