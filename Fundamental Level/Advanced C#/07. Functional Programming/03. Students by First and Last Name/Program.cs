using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students_by_First_and_Last_Name
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
				new Student("pesho", "peshov", 25, "00321", "32-13-314", "pesho@abv.bg", new List<int>(){ 1, 6, 5, 6, 4, 6 }, 1),
				new Student("pesho1", "peshov1", 26, "00322", "32-13-315", "pesho1@abv.bg", new List<int>(){ 2, 6, 5, 6, 4, 6 }, 2),
				new Student("pesho2", "peshov2", 27, "00323", "32-13-316", "pesho2@abv.bg", new List<int>(){ 3, 6, 5, 6, 4, 6 }, 3),
				new Student("mimeto", "peshova", 18, "00320", "32-13-313", "mimeto@abv.bg", new List<int>(){ 6, 6, 4, 4, 6, 6 }, 2),
				new Student("staropramena", "burgaska", 18, "007", "18-69-300", "staropramena@bira.bg", new List<int>(){6,6,6,6,6,5},2),
				new Student("ariana", "kamenska", 18, "ooyeah", "telefon", "ariana@bira.bg", new List<int>(){6,6,6,5,5,6,6,6}, 2)
			};

			var firstBeforeLast =
				from student in students
				where student.FirstName.CompareTo(student.LastName) < 0
				select student;

			foreach (var student in firstBeforeLast)
			{
				Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
			}
		}
	}
}
