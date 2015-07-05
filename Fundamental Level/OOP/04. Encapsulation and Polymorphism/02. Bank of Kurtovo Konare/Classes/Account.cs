using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
	public abstract class Account : IAccount//, IDepositable
	{
		private decimal balance;
		private Customer customer;

		protected Account(Customer customer, decimal startingBalance, double interestRate)
		{
			this.Customer = customer;
			this.Balance = startingBalance;
			this.InterestRate = interestRate;
			//this.RequaredMonths = 0;
		}

		public Customer Customer
		{
			get
			{
				return this.customer;
			}
			private set
			{
				if (value == null)
				{
					throw new ArgumentException("customer can't be null");
				}
				this.customer = value;
			}
		}

		public decimal Balance
		{
			get
			{
				return this.balance;
			}
			set
			{
				// for mortgage and loan accounts ballance is positive or negative ????
				//if (value <= 0)
				//{
				//	throw new ArgumentException("starting balance have to be positive");
				//}
				this.balance = value;
			}
		}

		protected int RequaredMonths { get; set; }

		public double InterestRate { get; set; }

		public virtual double GetIntrest(int months)
		{
			return (double)(this.Balance * (decimal)(1 + this.InterestRate * months));
		}

		public void Deposit(decimal amount)
		{
			if (amount <= 0)
			{
				throw new ArgumentException("deposit amount have to be positive");
			}

			this.Balance += amount;
		}
	}
}
