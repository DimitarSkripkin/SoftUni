using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Student_Class
{
	public class Student
	{
		private int grade;
		private string name;
		private int age;

		public Student(string name, int grade, int age = 0)
		{
			this.Name = name;
			this.Grade = grade;
			this.Age = age;
		}

		public event PropertyChangeEventHandler PropertyChanged;

		public int Grade
		{
			get
			{
				return this.grade;
			}
			set
			{
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Grade", this.grade, value));
				}
				grade = value;
			}
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Name", this.name, value));
				}
				name = value;
			}
		}

		public int Age
		{
			get
			{
				return this.age;
			}
			set
			{
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Age", this.age, value));
				}
				age = value;
			}
		}
	}
}