using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
	public enum CustomerType
	{
		OneTime, Regular, Golden, Diamond
	}

	public class Customer : ICloneable, IComparable<Customer>
	{
		public Customer(string firstName, string middleName, string lastName, string id, string permanentAddress, string phone, string email, CustomerType type, IList<Payment> payments)
		{
			this.FirstName = firstName;
			this.MiddleName = middleName;
			this.LastName = lastName;
			this.ID = id;
			this.PermanentAddress = permanentAddress;
			this.Phone = phone;
			this.Email = email;

			this.Type = type;
			this.Payments = new List<Payment>(payments);
		}

		public Customer(Customer other)
			: this(other.FirstName, other.MiddleName, other.LastName, other.ID, other.PermanentAddress, other.Phone, other.Email, other.Type, other.Payments)
		{
		}

		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string ID { get; set; }
		public string PermanentAddress { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

		public CustomerType Type { get; set; }
		public IList<Payment> Payments { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as Customer;
			if (other == null)
			{
				return false;
			}

			return this.FirstName == other.FirstName
				&& this.MiddleName == other.MiddleName
				&& this.LastName == other.LastName
				&& this.ID == other.ID
				&& this.PermanentAddress == other.PermanentAddress
				&& this.Phone == other.Phone
				&& this.Email == other.Email
				&& this.Type == other.Type
				&& this.Payments.Equals(other.Payments);
		}

		public override int GetHashCode()
		{
			//return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.Type.GetHashCode();
			return this.ToString().GetHashCode() ^ this.Payments.GetHashCode();
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
			sb.AppendLine(string.Format("ID: {0}, ADDRESS: {1}, PHONE: {2}, TYPE: {3}", this.ID, this.PermanentAddress, this.Phone, this.Type));

			return sb.ToString();
		}

		public object Clone()
		{
			return new Customer(this);
		}

		public int CompareTo(Customer other)
		{
			var thisFullName = string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
			var otherFullName = string.Format("{0} {1} {2}", other.FirstName, other.MiddleName, other.LastName);

			int compare = string.Compare(thisFullName, otherFullName, StringComparison.InvariantCulture);

			if (compare != 0)
			{
				return compare;
				//return -compare;
			}

			return this.ID.CompareTo(other.ID);
			//return -this.ID.CompareTo(other.ID);
		}

		public static bool operator ==(Customer customerA, Customer customerB)
		{
			if (customerA == null)
			{
				return false;
			}
			return customerA.Equals(customerB);
		}

		public static bool operator !=(Customer customerA, Customer customerB)
		{
			if (customerA == null)
			{
				return false;
			}
			return !customerA.Equals(customerB);
		}
	}
}
