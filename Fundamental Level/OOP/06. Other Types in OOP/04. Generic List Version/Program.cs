using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Generic_List_Version
{
	using _03.Generic_List;
	using System.Reflection;

	class Program
	{
		static void Main(string[] args)
		{
			var versions = typeof(GenericList<>)
				.GetCustomAttributes<CustomVersionAttribute>(false);

			foreach (object ver in versions)
			{
				CustomVersionAttribute v = (ver as CustomVersionAttribute);
				Console.WriteLine("major: {0}, minor: {1}", v.Major, v.Minor);
			}
		}
	}
}
