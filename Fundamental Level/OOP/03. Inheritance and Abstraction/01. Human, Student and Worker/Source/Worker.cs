using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
	public class Worker : Human
	{
		private const int WorkingDaysPerWeek = 5;
		private decimal weekSalary;
		private int workHoursPerDay;

		public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
			: base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHoursPerDay;
		}

		public decimal WeekSalary
		{
			get
			{
				return weekSalary;
			}
			set
			{
				if (value <= 0m)
				{
					throw new ArgumentException("weekSalary have to be bigger then 0");
				}
				weekSalary = value;
			}
		}
		public int WorkHoursPerDay
		{
			get
			{
				return workHoursPerDay;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("workHoursPerDay have to be bigger then 0");
				}
				workHoursPerDay = value;
			}
		}

		public decimal MoneyPerHour()
		{
			return WeekSalary / (WorkHoursPerDay * WorkingDaysPerWeek);
		}

		public override string ToString()
		{
			return string.Format("{0}, Payment per hour: {1}", base.ToString(), this.MoneyPerHour());
		}
	}
}
