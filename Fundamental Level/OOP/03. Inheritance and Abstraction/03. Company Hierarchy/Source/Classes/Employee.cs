﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public abstract class Employee : Person, IEmployee
	{
		private decimal salary;
		private Department department;

		protected Employee(string firsName, string lastName, int id, decimal salary, Department department)
			: base(firsName,lastName,id)
		{
			this.Salary = salary;
			this.Department = department;
		}

		public decimal Salary
		{
			get
			{
				return this.salary;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("salary have to be more then 0");
				}
				this.salary = value;
			}
		}

		public Department Department
		{
			get
			{
				return this.department;
			}
			set
			{
				this.department = value;
			}
		}
	}
}
