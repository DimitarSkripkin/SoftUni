using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
	public class Student : Human
	{
		private string facultyNumber;

		public Student(string firstName, string lastName, string facultyNumber)
			: base(firstName, lastName)
		{
			this.FacultyNumber = facultyNumber;
		}

		public string FacultyNumber
		{
			get
			{
				return facultyNumber;
			}
			set
			{
				if (value.Length < 5 || value.Length > 10)
				{
					throw new ArgumentException("facultyNumber have to be between 5 and 10 digits/letters");
				}
				foreach (var c in value)
				{
					if (!char.IsLetterOrDigit(c))
					{
						throw new ArgumentException("facultyNumber have to consist of digits and letters only");
					}
				}
				facultyNumber = value;
			}
		}

		public override string ToString()
		{
			return string.Format("{0}, Faculty number: {1}", base.ToString(), facultyNumber);
		}
	}
}
