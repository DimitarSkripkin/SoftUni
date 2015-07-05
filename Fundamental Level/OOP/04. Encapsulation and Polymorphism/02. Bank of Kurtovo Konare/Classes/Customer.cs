using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
	public enum CustomerType
	{
		Individual,
		Company
	}

	public class Customer
	{
		//private string name;
		//private CustomerType type;

		public Customer(string name, CustomerType type)
		{
			this.Name = name;
			this.Type = type;
		}

		public string Name { get; set; }
		public CustomerType Type { get; set; }

		public override string ToString()
		{
			return string.Format("name: {0}, type: {1}", this.Name, this.Type);
		}
	}
}
