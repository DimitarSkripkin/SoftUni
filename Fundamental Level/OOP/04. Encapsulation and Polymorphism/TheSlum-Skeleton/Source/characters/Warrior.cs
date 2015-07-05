using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	using Interfaces;

	public class Warrior : MyCharacter, IAttack
	{
		public Warrior(string id, int x, int y, Team team, int healthPoints = 200, int defensePoints = 100, int attackPoints = 150, int range = 2)
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
			return string.Format("{0}, Attack: {1}", base.ToString(), AttackPoints );
		}
	}
}
