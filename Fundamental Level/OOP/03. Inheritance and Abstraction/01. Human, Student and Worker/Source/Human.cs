using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
	public abstract class Human
	{
		private string firstName, lastName;

		protected Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("firstName can't be null or empty");
				}
				firstName = value.Trim();
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("lastName can't be null or empty");
				}
				lastName = value.Trim();
			}
		}

		public override string ToString()
		{
			return string.Format("First name: {0}, Last name: {1}", firstName, lastName);
		}
	}
}
