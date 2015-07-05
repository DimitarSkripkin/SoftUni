using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	public class Injection : Bonus
	{
		private const int HealthEffect = 200;

		public Injection(string id)
			: base(id, HealthEffect, 0, 0)
		{
			base.Countdown = 3;
			//base.Timeout = 3;
			base.HasTimedOut = false;
		}
	}
}
