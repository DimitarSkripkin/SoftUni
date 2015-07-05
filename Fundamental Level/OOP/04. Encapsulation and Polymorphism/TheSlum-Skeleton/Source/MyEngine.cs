using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Source
{
	using GameEngine;

	public class MyEngine : Engine
	{
		protected override void ExecuteCommand(string[] inputParams)
		{
			switch (inputParams[0])
			{
				case "status":
					this.PrintCharactersStatus(this.characterList);
					break;

				case "create":
					CreateCharacter(inputParams);
					break;

				case "add":
					AddItem(inputParams);
					break;
			}
		}

		protected override void CreateCharacter(string[] inputParams)
		{
			string id = inputParams[2];
			int x = int.Parse(inputParams[3]);
			int y = int.Parse(inputParams[4]);
			Team team = (Team)Enum.Parse(typeof(Team), inputParams[5]);
			Character character;

			switch (inputParams[1])
			{
				case "warrior":
					character = new Warrior(id, x, y, team);
					break;
				case "mage":
					character = new Mage(id, x, y, team);
					break;
				case "healer":
					character = new Healer(id, x, y, team);
					break;
				default:
					throw new NotImplementedException();
					//break;
			}

			base.characterList.Add(character);
		}

		protected void AddItem(string[] inputParams)
		{
			Item add;

			switch (inputParams[2])
			{
				case "axe":
					add = new Axe(inputParams[3]);
					break;
				case "shield":
					add = new Shield(inputParams[3]);
					break;
				case "pill":
					add = new Pill(inputParams[3]);
					//add = new Bonus(inputParams[3], 200);
					break;
				case "injection":
					add = new Injection(inputParams[3]);
					//add = new Bonus(inputParams[3], 0, 100);
					break;
				default:
					throw new NotImplementedException();
					//break;
			}

			GetCharacterById(inputParams[1]).AddToInventory(add);
		}
	}
}
