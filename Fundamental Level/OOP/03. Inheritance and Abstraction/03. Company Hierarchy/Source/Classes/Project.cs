using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Classes
{
	using Interfaces;

	public class Project : IProject
	{
		private string name;
		private DateTime startedDate;
		private string details;
		private Status state;

		public Project(string name, DateTime startingDate, string details, Status state)
		{
			this.Name = name;
			this.StartDate = startingDate;
			this.Details = details;
			this.state = state;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("name can't be null or empty");
				}
				this.name = value.Trim();
			}
		}

		public DateTime StartDate
		{
			get
			{
				return this.startedDate;
			}
			private set
			{
				this.startedDate = value;
			}
		}

		public string Details
		{
			get
			{
				return this.details;
			}
			set
			{
				this.details = value.Trim();
			}
		}

		public Status State
		{
			get {
				return this.state;
			}
		}

		public void CloseProject()
		{
			this.state = Status.Closed;
		}

		public override string ToString()
		{
			return string.Format("project name: {0}\nstarted at: {1}\nstatus: {2}\ndetails: {3}",
				name, startedDate.ToString("dd.MM.yyyy"), state, details );
		}
	}
}
