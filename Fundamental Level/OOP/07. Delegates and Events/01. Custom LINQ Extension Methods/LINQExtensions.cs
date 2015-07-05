using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Custom_LINQ_Extension_Methods
{
	public static class LINQExtensions
	{
		public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			var toReturn = new List<T>();
			foreach (var item in collection)
			{
				if (!predicate(item))
				{
					toReturn.Add(item);
				}
			}
			return toReturn;
		}

		public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> parameter)
		{
			var max = parameter(collection.FirstOrDefault());

			foreach (var item in collection)
			{
				var currentItem = parameter(item);
				if (Comparer<TSelector>.Default.Compare(max, currentItem) < 0)
				{
					max = currentItem;
				}
			}

			return max;
		}
	}
}
