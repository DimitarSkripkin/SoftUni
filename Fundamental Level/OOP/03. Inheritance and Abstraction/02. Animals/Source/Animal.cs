using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
	public enum GENDER
	{
		Male,
		Female
	}

	public abstract class Animal : ISoundProducible
	{
		const int MinAge = 0;
		const int MaxAge = 30;

		private string name;
		private GENDER gender;
		private int age;

		protected Animal(string name, int age, GENDER gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("name can't be null or empty");
				}
				name = value.Trim();
			}
		}

		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				if (value < MinAge || value > MaxAge)
				{
					throw new ArgumentException(
						string.Format("age have to be between {0} and {1}",
							MinAge, MaxAge)
					);
				}
				age = value;
			}
		}

		public GENDER Gender
		{
			get
			{
				return gender;
			}
			set
			{
				gender = value;
			}
		}

		public abstract void ProduceSound();
	}
}
