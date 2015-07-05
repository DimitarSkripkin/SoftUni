using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	public abstract class MyCharacter : Character
	{
		public MyCharacter(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
			: base(id, x, y, healthPoints, defensePoints, team, range)
		{
		}

		public override Character GetTarget(IEnumerable<Character> targetsList)
		{
			foreach (var target in targetsList)
			{
				if (target.IsAlive && target.Team != this.Team && target != this)
				{
					return target;
				}
			}
			return null;
		}

		public override void AddToInventory(Item item)
		{
			this.Inventory.Add(item);
			this.RemoveItemEffects(item);
		}

		public override void RemoveFromInventory(Item item)
		{
			if (item is Injection && this.HealthPoints < 1)
			{
				//this.HealthPoints = 1;
				this.IsAlive = true;
			}
			this.Inventory.Remove(item);
			this.RemoveItemEffects(item);
		}
	}
}
