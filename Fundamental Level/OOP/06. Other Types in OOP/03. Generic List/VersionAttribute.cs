using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
	[AttributeUsage(
		AttributeTargets.Struct
		| AttributeTargets.Class
		| AttributeTargets.Interface
		| AttributeTargets.Enum
		| AttributeTargets.Method,
		AllowMultiple = false)]
	public class CustomVersionAttribute : Attribute
	{
		public CustomVersionAttribute(int major, int minor)
		{
			this.Major = major;
			this.Minor = minor;
		}

		public int Major { get; set; }
		public int Minor { get; set; }
	}
}
