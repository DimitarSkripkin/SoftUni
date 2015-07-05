using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public abstract class Person : IPerson
	{
		private int id;
		string firstName, lastName;

		protected Person(string firstName, string lastName, int id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.ID = id;
		}

		public int ID
		{
			get
			{
				return this.id;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("id have to be bigger then 0");
				}
				this.id = value;
			}
		}

		public string FirstName
		{
			get
			{
				return this.firstName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("firstName can't be null or empty");
				}
				this.firstName = value.Trim();
			}
		}

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("lastName can't be null or empty");
				}
				this.lastName = value.Trim();
			}
		}

		public override string ToString()
		{
			return string.Format("First name: {0}, Last name: {1}, ID: {2}", firstName, lastName, id);
		}
    }
}
