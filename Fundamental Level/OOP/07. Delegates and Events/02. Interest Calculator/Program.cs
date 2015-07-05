using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interest_Calculator
{
	class Program
	{
		static decimal GetSimpleInterest(decimal sum, double interest, int years)
		{
			return sum * (decimal)(1 + (interest / 100) * years);
		}

		static decimal GetCompoundInterest(decimal sum, double interest, int years)
		{
			int n = 12;
			return sum * (decimal)Math.Pow(1 + interest / (100 * n), n * years);
		}

		static void Main(string[] args)
		{
			decimal sum = 500;
			double interestPercent = 5.6;
			int years = 10;

			InterestCalculator simpleInterest = new InterestCalculator(sum, interestPercent, years, GetSimpleInterest);
			Console.WriteLine(simpleInterest);

			sum = 2500;
			interestPercent = 7.2;
			years = 15;
			InterestCalculator compoundInterest = new InterestCalculator(sum, interestPercent, years, GetSimpleInterest);
			Console.WriteLine(compoundInterest);
		}
	}
}
