using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Weak_Students
{
	public static class ListExtension
	{
		public static bool HaveExactlyTwo(this List<int> list, int value = 2)
		{
			return list.Count(val => val == value) == 2;
		}
	}
}
