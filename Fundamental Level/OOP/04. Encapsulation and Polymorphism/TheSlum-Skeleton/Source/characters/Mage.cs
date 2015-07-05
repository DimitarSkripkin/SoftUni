using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	using Interfaces;

	public class Mage : MyCharacter, IAttack
	{
		public Mage(string id, int x, int y, Team team, int healthPoints = 150, int defensePoints = 50, int attackPoints = 300, int range = 5)
			: base(id, x, y, healthPoints, defensePoints, team, range)
		{
			this.AttackPoints = attackPoints;
		}

		public int AttackPoints { get; set; }
		//public int AttackPoints
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
			return string.Format("{0}, Attack: {1}", base.ToString(), AttackPoints);
		}
	}
}
