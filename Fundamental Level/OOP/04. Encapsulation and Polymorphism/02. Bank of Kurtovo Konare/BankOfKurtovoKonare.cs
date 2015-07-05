using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
	class BankOfKurtovoKonare
	{
		static void Main(string[] args)
		{
			var c1 = new Customer("pesho", CustomerType.Individual);
			var c2 = new Customer("pesho soft", CustomerType.Company);

			var accounts = new List<IAccount>()
			{
				new DepositAccount( c1, 5000m, 0.7 ),
				new DepositAccount( c2, 5000m, 0.7 ),

				new LoanAccount( c1, 5m, 0.7 ),
				new LoanAccount( c2, 5m, 0.7 ),

				new MortgageAccount( c1, 5m, 0.7 ),
				new MortgageAccount( c2, 5m, 0.7 )
			};

			Console.WriteLine("{0}, intrest {1}", accounts[0].Customer, accounts[0].GetIntrest(3));
			Console.WriteLine("{0}, intrest {1}", accounts[1].Customer, accounts[1].GetIntrest(3));
			Console.WriteLine();
			Console.WriteLine("{0}, intrest {1}", accounts[2].Customer, accounts[2].GetIntrest(4));
			Console.WriteLine("{0}, intrest {1}", accounts[3].Customer, accounts[3].GetIntrest(2));
			Console.WriteLine();
			Console.WriteLine("{0}, intrest {1}", accounts[4].Customer, accounts[4].GetIntrest(13));
			Console.WriteLine("{0}, intrest {1}", accounts[5].Customer, accounts[5].GetIntrest(11));
		}
	}
}
