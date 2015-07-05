using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public class Sale : ISale
	{
		private string productName;
		private DateTime saleDate;
		private decimal productPrice;

		public Sale(string productName, DateTime saleDate, decimal productPrice)
		{
			this.ProductName = productName;
			this.SaleDate = saleDate;
			this.ProductPrice = productPrice;
		}

		public string ProductName
		{
			get
			{
				return this.productName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("name can't be null or empty");
				}
				this.productName = value.Trim();
			}
		}

		public DateTime SaleDate
		{
			get
			{
				return this.saleDate;
			}
			set
			{
				this.saleDate = value;
			}
		}

		public decimal ProductPrice
		{
			get
			{
				return this.productPrice;
			}
			set
			{
				if (value <= 0m)
				{
					throw new ArgumentException("price have to be bigger then 0");
				}
				this.productPrice = value;
			}
		}

		public override string ToString()
		{
			return string.Format("name: {0}, date: {1}, price: {2}", productName, saleDate.ToString("dd.MM.yyyy"), productPrice);
		}
	}
}
