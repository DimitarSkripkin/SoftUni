using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interest_Calculator
{
	public delegate decimal InterestDelegate(decimal money, double interest, int years);

	public class InterestCalculator
	{
		private decimal sum;
		private double interestPercent;
		private int years;
		private InterestDelegate interestFunction;

		public InterestCalculator(decimal money, double interest, int years, InterestDelegate interestFunc)
		{
			this.Sum = money;
			this.InterestPercent = interest;
			this.Years = years;
			this.InterestFunction = interestFunc;
		}

		public decimal Sum
		{
			get
			{
				return this.sum;
			}
			set
			{
				if (value < 0m)
				{
					throw new ArgumentException();
				}
				this.sum = value;
			}
		}

		public double InterestPercent
		{
			get
			{
				return this.interestPercent;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException();
				}
				this.interestPercent = value;
			}
		}

		public int Years
		{
			get
			{
				return this.years;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException();
				}
				this.years = value;
			}
		}

		public InterestDelegate InterestFunction
		{
			get
			{
				return this.interestFunction;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentException();
				}
				this.interestFunction = value;
			}
		}

		public decimal Result
		{
			get
			{
				return this.InterestFunction(this.Sum, this.InterestPercent, this.Years);
			}
		}

		public override string ToString()
		{
			return this.Result.ToString("C4");
		}
	}
}
