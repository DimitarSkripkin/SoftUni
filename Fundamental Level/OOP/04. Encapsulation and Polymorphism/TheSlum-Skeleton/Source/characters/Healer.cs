using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	using Interfaces;

	public class Healer : MyCharacter, IHeal
	{
		public Healer(string id, int x, int y, Team team, int healthPoints = 75, int defensePoints = 50, int healingPoints = 60, int range = 6)
			: base(id, x, y, healthPoints, defensePoints, team, range)
		{
			this.HealingPoints = healingPoints;
		}

		public override Character GetTarget(IEnumerable<Character> targetsList)
		{
			foreach (var target in targetsList)
			{
				if (target.IsAlive && target.Team == this.Team && target != this)
				{
					return target;
				}
			}
			return null;
		}

		public int HealingPoints { get; set; }
		//public int HealingPoints
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public override string ToString()
		{
			return string.Format("{0}, Healing: {1}", base.ToString(), HealingPoints);
		}
	}
}
