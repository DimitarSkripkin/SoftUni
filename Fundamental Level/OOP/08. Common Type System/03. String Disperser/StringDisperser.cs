using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Disperser
{
	public class StringDisperser : IEnumerable, ICloneable, IComparable<StringDisperser>
	{
		private string[] args;

		public StringDisperser(params string[] args)
		{
			this.args = args.ToArray();
		}

		public StringDisperser(StringDisperser other)
			: this(other.args)
		{
		}

		public IEnumerator GetEnumerator()
		{
			var toIterate = ToString();

			for (int i = 0; i < toIterate.Length; ++i)
			{
				yield return toIterate[i];
			}
		}

		public object Clone()
		{
			return new StringDisperser(this.args);
		}

		public int CompareTo(StringDisperser other)
		{
			return ToString().CompareTo(other.ToString());
			//return -ToString().CompareTo(other.ToString());
		}

		public override bool Equals(object obj)
		{
			var other = obj as StringDisperser;
			if ( other == null ) {
				return false;
			}
			return Array.Equals(this.args, other.args);
		}

		public override int GetHashCode()
		{
			return this.args.GetHashCode();
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var str in args)
			{
				sb.Append(str);
			}

			return sb.ToString();
		}

		public static bool operator ==(StringDisperser sdA, StringDisperser sdB)
		{
			if (sdA == null)
			{
				return false;
			}
			return sdA.Equals(sdB);
		}

		public static bool operator !=(StringDisperser sdA, StringDisperser sdB)
		{
			if (sdA == null)
			{
				return false;
			}
			return !sdA.Equals(sdB);
		}
	}
}
