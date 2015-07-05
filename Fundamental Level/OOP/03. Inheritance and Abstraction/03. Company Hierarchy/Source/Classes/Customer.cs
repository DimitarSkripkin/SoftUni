using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public class Customer : Person, ICustomer
	{
		private decimal netPurchaseAmount;

		public Customer(string firstName, string lastName, int id, decimal netPurchaseAmount)
			: base(firstName,lastName,id)
		{
			this.NetPurchaseAmount = netPurchaseAmount;
		}

		public decimal NetPurchaseAmount
		{
			get
			{
				return this.netPurchaseAmount;
			}
			set
			{
				if (value < 0m)
				{
					throw new ArgumentException("net purchase amount can't be negative");
				}
				this.netPurchaseAmount = value;
			}
		}

		public override string ToString()
		{
			return string.Format("{0}, net purchase amount: {1}", base.ToString(), netPurchaseAmount);
		}
	}
}
