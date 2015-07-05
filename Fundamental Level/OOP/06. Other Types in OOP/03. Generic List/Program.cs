using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _03.Generic_List
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new GenericList<int>();
			for (int i = 1; i < 16; ++i)
			{
				list.Add(i);
			}
			Console.WriteLine("max: {0}, min: {1}", list.Max(), list.Min());
			Console.WriteLine("list: {0}", list);
			
			list.Add(5);
			list.Add(7);
			list.Add(5);
			list.Add(7);
			list.Add(5);
			list.Add(7);
			list.Add(5);
			list.Add(7);
			Console.WriteLine("after adding: {0}", list);

			Console.WriteLine(list[0]);
			list[0] = 8;
			list.Insert(0, 42);

			Console.WriteLine("after insert: {0}", list);

			list.RemoveAt(5);
			Console.WriteLine("after removing at position 5: {0}", list);

			list.RemoveAll(7);
			Console.WriteLine("after removing all 7: {0}", list);

			list.Insert(list.Count, 4);
			Console.WriteLine("after insert: {0}", list);

			list.Insert(1, 32);
			Console.WriteLine("after insert: {0}", list);
		}
	}
}
