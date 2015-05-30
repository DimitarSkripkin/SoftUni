using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Students_Enrolled_in_2014
{
	public class Student
	{
		public string FirstName;
		public string LastName;
		public int Age;
		public string FacultyNumber;
		public string Phone;
		public string Email;
		public List<int> Marks;
		public int GroupNumber;

		public Student(string firstName, string lastName, int age, string facultyNumber,
			string phone, string email, List<int> marks, int groupNumber)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			FacultyNumber = facultyNumber;
			Phone = phone;
			Email = email;
			Marks = marks;
			GroupNumber = groupNumber;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>(){
				new Student("pesho", "peshov", 25, "0032145", "02 32-13-314", "pesho@abv.bg", new List<int>(){ 1, 6, 5, 6, 1, 6 }, 1),
				new Student("pesho1", "peshov1", 26, "00322", "32-13-315", "pesho1@abv.bg", new List<int>(){ 2, 6, 5, 6, 2, 6 }, 2),
				new Student("pesho2", "peshov2", 27, "00323", "32-13-316", "pesho2@abv.bg", new List<int>(){ 3, 6, 5, 6, 4, 6 }, 3),
				new Student("mimeto", "peshova", 18, "0032145", "+3592 32-13-313", "mimeto@abv.bg", new List<int>(){ 6, 6, 4, 4, 6, 6 }, 2),
				new Student("staropramena", "burgaska", 18, "0072146", "18-69-300", "staropramena@bira.bg", new List<int>(){6,6,6,6,6,5},2),
				new Student("ariana", "kamenska", 18, "ooyeah", "+359 2telefon", "ariana@bira.bg", new List<int>(){6,6,6,5,5,6,6,6}, 2)
			};

			var enrolled2014 = students
				.Where(student => student.FacultyNumber.Length > 5 && student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4' )
				.Select(student =>
				new
				{
					student.FacultyNumber,
					student.Marks
				})
				.ToArray();

			foreach (var student in enrolled2014)
			{
				Console.WriteLine("{0}, Marks {1}", student.FacultyNumber, string.Join(", ", student.Marks));
			}
		}
	}
}
