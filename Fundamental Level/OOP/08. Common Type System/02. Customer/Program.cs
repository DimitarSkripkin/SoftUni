using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Payment> payments = new List<Payment>()
			{
				new Payment("halba", 2.5m),
				new Payment("sokche", 1.5m)
			};

			Customer pesho = new Customer("pesho", "birata", "peshov", "3132134448",
				"na kruchmata", "+359777777775", "pesho@napobira.com", CustomerType.Diamond, payments);

			Customer peshoSortingTest = new Customer(pesho);
			peshoSortingTest.ID = "03132134448";

			Console.WriteLine(pesho);

			Customer mariika = new Customer("mariika", "OneTime", "peshova", "3138786769",
				"do kruchmata", "+359777777779", "mariika@napobira.com", CustomerType.OneTime, payments);

			Console.WriteLine(mariika);
			Console.WriteLine("==============================================");

			var customerList = new List<Customer>()
			{
				pesho,
				mariika,
				new Customer("pesho", "malkiq", "peshov", "0549074444",
					"nad kruchmata", "+359777777775", "pesho@napomalkabira.com", CustomerType.Golden, payments),
				peshoSortingTest
			};

			customerList.Sort();

			Console.WriteLine(string.Join("\n", customerList));
		}
	}
}
