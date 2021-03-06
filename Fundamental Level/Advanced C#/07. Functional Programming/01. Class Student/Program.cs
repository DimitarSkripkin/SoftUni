﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Class_Student
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

		public string ToString()
		{
			return string.Format("{0} {1}, Age {2}, FNum {3}, Phone {4}, E-mail {5}, Marks {6}, GroupNum {7}",
				FirstName, LastName, Age, FacultyNumber, Phone, Email, string.Join(" ", Marks), GroupNumber);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>(){
				new Student("pesho", "peshov", 25, "00321", "32-13-314", "pesho@abv.bg", new List<int>(){ 1, 6, 5, 6, 4, 6 }, 1),
				new Student("pesho1", "peshov1", 26, "00322", "32-13-315", "pesho1@abv.bg", new List<int>(){ 2, 6, 5, 6, 4, 6 }, 2),
				new Student("pesho2", "peshov2", 27, "00323", "32-13-316", "pesho2@abv.bg", new List<int>(){ 3, 6, 5, 6, 4, 6 }, 3)
			};
		}
	}
}
