using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	public class Pill : Bonus
	{
		const int AttackEffect = 100;

		public Pill(string id)
			: base(id, 0, 0, AttackEffect )
		{
			base.Countdown = 1;
			//base.Timeout = 1;
			base.HasTimedOut = false;
		}
	}
}
