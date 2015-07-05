using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
	public class LoanAccount : Account, IDepositable
	{
		public LoanAccount(Customer customer, decimal startingBalance, double interestRate)
			: base(customer, startingBalance, interestRate)
		{
			if (customer.Type == CustomerType.Company)
			{
				base.RequaredMonths = 2;
			}
			else
			{
				base.RequaredMonths = 3;
			}
		}

		public override double GetIntrest(int months)
		{
			if (months < this.RequaredMonths)
			{
				return 0;
			}
			return base.GetIntrest(months);
		}
	}
}
