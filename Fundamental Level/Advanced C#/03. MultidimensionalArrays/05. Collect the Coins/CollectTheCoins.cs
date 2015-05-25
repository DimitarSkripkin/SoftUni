using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CollectTheCoins
{
	static void Main(string[] args)
	{
		int boardRows = 4;
		char[][] board = new char[boardRows][];
		for (int i = 0; i < boardRows; ++i)
		{
			board[i] = Console.ReadLine().ToArray();
		}

		string command = Console.ReadLine();
		int playerPosX = 0,
			playerPosY = 0,
			coinsColected = 0,
			wallHits = 0;
		for (int move = 0; move < command.Length; ++move)
		{
			switch (command[move])
			{
				case 'V':
					if (playerPosY < boardRows - 1 && playerPosX < board[playerPosY + 1].Length - 1)
					{
						++playerPosY;
					}
					else
					{
						++wallHits;
					}
					break;
				case '^':
					if (playerPosY > 0 && playerPosX < board[playerPosY - 1].Length - 1)
					{
						--playerPosY;
					}
					else
					{
						++wallHits;
					}
					break;
				case '<':
					if (playerPosX > 0)
					{
						--playerPosX;
					}
					else
					{
						++wallHits;
					}
					break;
				case '>':
					if (playerPosX < board[playerPosY].Length - 1)
					{
						++playerPosX;
					}
					else
					{
						++wallHits;
					}
					break;
			}
			if (board[playerPosY][playerPosX] == '$')
			{
				++coinsColected;
				board[playerPosY][playerPosX] = '@';
			}
		}

		Console.WriteLine("Coins collected: {0}\nWalls hit: {1}",coinsColected,wallHits);
		Console.WriteLine();

		// for debug
		//for (int i = 0; i < boardRows; ++i)
		//{
		//	foreach (char c in board[i])
		//	{
		//		Console.Write(c);
		//	}
		//	Console.WriteLine();
		//}
	}
}