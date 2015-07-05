using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
	public class MortgageAccount : Account
	{
		public MortgageAccount(Customer customer, decimal startingBalance, double interestRate)
			: base(customer, startingBalance, interestRate)
		{
			if (customer.Type == CustomerType.Company)
			{
				base.RequaredMonths = 12;
			}
			else
			{
				base.RequaredMonths = 6;
			}
		}

		public override double GetIntrest(int months)
		{
			if (months < this.RequaredMonths)
			{
				return base.GetIntrest(months) / 2.0;
			}
			return base.GetIntrest(months);
		}
	}
}
