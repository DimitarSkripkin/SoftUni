using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public class SalesEmployee : RegularEmployee, ISalesEmployee
	{
		private HashSet<Sale> sales;

		public SalesEmployee(string firsName, string lastName, int id, decimal salary, IList<Sale> sales)
			: base(firsName, lastName, id, salary, Department.Sales)
		{
			this.sales = new HashSet<Sale>(sales);
		}

		public void AddSales(ISet<Sale> sales)
		{
			//foreach (var sale in sales)
			//{
			//	this.sales.Add(sale);
			//}
			this.sales.UnionWith(sales);
		}

		public ISet<Sale> Sales
		{
			get
			{
				return this.sales;
			}
		}

		public override string ToString()
		{
			StringBuilder toReturn = new StringBuilder(string.Format("{0}\nSales\n", base.ToString()));
			foreach (var sale in sales)
			{
				toReturn.AppendLine(sale.ToString());
			}
			return toReturn.ToString();
		}
	}
}
