using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>()
			{
				new Student("pesho", "peshov", "00001"),
				new Student("acho", "mastilov", "00002"),
				new Student("tacho", "tochilov", "0200a"),
				new Student("hacho", "dobrilov", "0000b"),
				new Student("gosho", "peshov", "0100c"),

				new Student("tosho", "toshov", "12345678"),
				new Student("mariq", "mimeto", "1234567"),
				new Student("mistriq", "peshova", "12345"),
				new Student("tupotiq", "toshova", "123456"),
				new Student("lakomiq", "dobrilova", "123456789")
			};
			students = students
				.OrderBy(student => student.FacultyNumber)
				.ToList();

			foreach (var student in students)
			{
				Console.WriteLine(student);
			}
			Console.WriteLine(new string('-', 20));

			List<Worker> workers = new List<Worker>()
			{
				new Worker("pesho", "peshkata", 200m, 5),
				new Worker("pesho", "off ne znam", 100m, 5),
				new Worker("gosho", "oshkata", 150m, 5),
				new Worker("pesho", "mesho", 50m, 5),
				new Worker("gosho", "peshov", 350m, 5),

				new Worker("tosho", "peshov", 225m, 5),
				new Worker("toshka", "loshka", 175m, 5),
				new Worker("moshka", "igroshka", 60m, 5),
				new Worker("mariq", "rakiq", 70m, 5),
				new Worker("rosho", "roshev", 80m, 5)
			};
			workers = workers
				.OrderBy(worker => worker.MoneyPerHour())
				.ToList();

			foreach (var worker in workers)
			{
				Console.WriteLine(worker);
			}
			Console.WriteLine(new string('-', 20));

			List<Human> humans = new List<Human>(students);
			humans.AddRange(workers);

			humans = humans
				.OrderBy(human => human.FirstName)
				.ThenBy(human => human.LastName)
				.ToList();

			foreach (var human in humans)
			{
				Console.WriteLine(human);
			}
		}
	}
}
