using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ToTheStars
{
	struct Position
	{
		public float x, y;
	}
	struct StarSystem
	{
		public string name;
		public Position position;
	}

	static void Main(string[] args)
	{
		const int numberOfStarSystems = 3;
		StarSystem[] starsystems = new StarSystem[numberOfStarSystems];

		for (int i = 0; i < numberOfStarSystems; ++i)
		{
			string[] inputLine = Console.ReadLine().Split(' ');

			starsystems[i].name = inputLine[0].ToLower();
			starsystems[i].position.x = float.Parse(inputLine[1]);
			starsystems[i].position.y = float.Parse(inputLine[2]);
		}

		string[] input = Console.ReadLine().Split(' ');
		Position ship;
		ship.x = float.Parse(input[0]);
		ship.y = float.Parse(input[1]);

		int numberOfTurns = int.Parse(Console.ReadLine());

		while (numberOfTurns >= 0)
		{
			string output = "space";
			for (int i = 0; i < numberOfStarSystems; ++i)
			{
				if (starsystems[i].position.x - 1 <= ship.x && starsystems[i].position.x + 1 >= ship.x
					&& starsystems[i].position.y - 1 <= ship.y && starsystems[i].position.y + 1 >= ship.y)
				{
					output = starsystems[i].name;
					break;
				}
			}

			Console.WriteLine(output);

			ship.y += 1.0f;
			--numberOfTurns;
		}
	}
}