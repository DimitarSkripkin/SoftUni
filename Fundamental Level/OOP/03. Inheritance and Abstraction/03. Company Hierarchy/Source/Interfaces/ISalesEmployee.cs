using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	using Classes;

	interface ISalesEmployee
	{
		void AddSales(ISet<Sale> sales);
		//IList<Sale> Sales { get; }
		ISet<Sale> Sales { get; }
		string ToString();
	}
}
