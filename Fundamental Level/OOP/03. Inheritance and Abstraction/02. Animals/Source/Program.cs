using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal[] animals = new Animal[]{
				new Tomcat("pesho", 5),
				new Kitten("mariika", 3),
				new Dog("kucho", 2, GENDER.Male),
				new Dog("staro", 13, GENDER.Female),
				new Frog("Trevor", 12, GENDER.Male),
				new Tomcat("gosho", 12),
				new Kitten("smatka", 15),
				new Frog("sasho", 10, GENDER.Male),
				new Frog("tanq", 13, GENDER.Female),
			};

			//foreach (var animal in animals)
			//{
			//	animal.ProduceSound();
			//}

			var catAvgAge = animals.Where(a => (a is Cat)).Average(cat => cat.Age);
			var dogAvgAge = animals.Where(a => (a is Dog)).Average(dog => dog.Age);
			var frogAvgAge = animals.Where(a => (a is Frog)).Average(frog => frog.Age);

			Console.WriteLine("cat average age: {0:0.##}\ndog average age: {1:0.##}\nfrog average age: {2:0.##}",
				catAvgAge, dogAvgAge, frogAvgAge);
		}
	}
}
