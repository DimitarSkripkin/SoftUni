using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
	public class DepositAccount : Account, IWithdrawable
	{
		public DepositAccount(Customer customer, decimal startingBalance, double interestRate)
			: base(customer, startingBalance, interestRate)
		{
		}

		public void Withdraw(decimal amount)
		{
			if (amount <= 0)
			{
				throw new ArgumentException("withdraw amount have to be positive");
			}

			this.Balance -= amount;
		}

		public override double GetIntrest(int months)
		{
			if (this.Balance > 0 && this.Balance < 1000)
			{
				return 0;
			}
			return base.GetIntrest(months);
		}
	}
}
