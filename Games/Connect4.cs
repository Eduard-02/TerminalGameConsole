namespace TerminalGameConsole.Games;

public static class Connect4
{
	static char[,] connectGrid = new char[6, 7];
	static int connectPlays = 42;
	static int player = 1;

	public static void InitializeGridConnect()
	{
		//Incialize grid to put white spaces
		for (int i = 0; i < 6; i++)
		{
			for (int j = 0; j < 7; j++)
			{
				connectGrid[i, j] = ' ';
			}
		}
	}
	public static void Play()
	{
		Console.WriteLine("\nWelcome to Connect 4 game!\nHere is the grid! Player 1 - x and Player 2 - o.\n");
					
		PrintGrid4();

		while (connectPlays != 0)
		{
			Console.WriteLine($"\nPlayer {player}, choose one column (0, 1, 2, 3, 4, 5, 6).");
			int line = -1;
			Console.Write("Column: ");
			if (!int.TryParse(Console.ReadLine(), out int column) || column < 0 || column > 6)
			{
				Console.WriteLine($"Invalid move, try again!");
				continue;
			}
				
			for (int i = 5; i >= 0; i--)
			{
				if (connectGrid[i, column] == ' ')
				{
					line = i;
					break;
				}
			}
			if (line == -1)
			{
				Console.WriteLine("Column full! Try again.");
				continue;
			}
				
			if (connectGrid[line, column] == 'x' || connectGrid[line, column] == 'o')
			{
				Console.WriteLine($"Invalid move, try again!");
				continue;
			}

			Console.WriteLine();
			if (player == 1)
			{
				connectGrid[line, column] = 'x';
				Console.Clear();
				PrintGrid4();
				
				if (CheckWinConnect4())
				{
					Console.WriteLine($"\nPlayer {player} wins!!!");
					break;
				}
			}
			else if (player == 2)
			{
				connectGrid[line, column] = 'o';
				Console.Clear();
				PrintGrid4();

				if (CheckWinConnect4())
				{
						Console.WriteLine($"\nPlayer {player} wins!!!");
						break;
				}
			}
				
			if (player == 1)
				player++;
			else if (player == 2)
				player--;
			connectPlays--;
			
			if (connectPlays == 0)
				Console.WriteLine("\nDraw");
		}
					
		static void PrintGrid4()
		{
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					Console.Write(connectGrid[i, j]);
					if (j < 6) Console.Write("|");
				}
				Console.WriteLine();
				if (i < 5) Console.WriteLine("-------------");
			}
		}
					
		static bool CheckWinConnect4()
		{
			for (int i = 0; i < 6; i++)
			{
				if ((connectGrid[i, 0] == 'x' && connectGrid[i, 1] == 'x' && connectGrid[i, 2] == 'x' && connectGrid[i, 3] == 'x')
				|| (connectGrid[i, 0] == 'o' && connectGrid[i, 1] == 'o' && connectGrid[i, 2] == 'o' && connectGrid[i, 3] == 'o')

				|| (connectGrid[i, 1] == 'x' && connectGrid[i, 2] == 'x' && connectGrid[i, 3] == 'x' && connectGrid[i, 4] == 'x')
				|| (connectGrid[i, 1] == 'o' && connectGrid[i, 2] == 'o' && connectGrid[i, 3] == 'o' && connectGrid[i, 4] == 'o')

				|| (connectGrid[i, 2] == 'x' && connectGrid[i, 3] == 'x' && connectGrid[i, 4] == 'x' && connectGrid[i, 5] == 'x')
				|| (connectGrid[i, 2] == 'o' && connectGrid[i, 3] == 'o' && connectGrid[i, 4] == 'o' && connectGrid[i, 5] == 'o')

				|| (connectGrid[i, 3] == 'x' && connectGrid[i, 4] == 'x' && connectGrid[i, 5] == 'x' && connectGrid[i, 6] == 'x')
				|| (connectGrid[i, 3] == 'o' && connectGrid[i, 4] == 'o' && connectGrid[i, 5] == 'o' && connectGrid[i, 6] == 'o')

				|| (connectGrid[0, i] == 'x' && connectGrid[1, i] == 'x' && connectGrid[2, i] == 'x' && connectGrid[3, i] == 'x')
				|| (connectGrid[0, i] == 'o' && connectGrid[1, i] == 'o' && connectGrid[2, i] == 'o' && connectGrid[3, i] == 'o')

				|| (connectGrid[1, i] == 'x' && connectGrid[2, i] == 'x' && connectGrid[3, i] == 'x' && connectGrid[4, i] == 'x')
				|| (connectGrid[1, i] == 'o' && connectGrid[2, i] == 'o' && connectGrid[3, i] == 'o' && connectGrid[4, i] == 'o')

				|| (connectGrid[2, i] == 'x' && connectGrid[3, i] == 'x' && connectGrid[4, i] == 'x' && connectGrid[5, i] == 'x')
				|| (connectGrid[2, i] == 'o' && connectGrid[3, i] == 'o' && connectGrid[4, i] == 'o' && connectGrid[5, i] == 'o'))
				return true;
			}

			if ((connectGrid[0, 0] == 'x' && connectGrid[1, 1] == 'x' && connectGrid[2, 2] == 'x' && 	connectGrid[3, 3] == 'x')
			|| (connectGrid[0, 0] == 'o' && connectGrid[1, 1] == 'o' && connectGrid[2, 2] == 'o' && connectGrid[3, 3] == 'o')

			|| (connectGrid[2, 2] == 'x' && connectGrid[3, 3] == 'x' && connectGrid[4, 4] == 'x' && connectGrid[5, 5] == 'x')
			|| (connectGrid[2, 2] == 'o' && connectGrid[3, 3] == 'o' && connectGrid[4, 4] == 'o' && connectGrid[5, 5] == 'o')

			|| (connectGrid[1, 0] == 'x' && connectGrid[2, 1] == 'x' && connectGrid[3, 2] == 'x' && connectGrid[4, 3] == 'x')
			|| (connectGrid[1, 0] == 'o' && connectGrid[2, 1] == 'o' && connectGrid[3, 2] == 'o' && connectGrid[4, 3] == 'o')

			|| (connectGrid[2, 1] == 'x' && connectGrid[3, 2] == 'x' && connectGrid[4, 3] == 'x' && connectGrid[5, 4] == 'x')
			|| (connectGrid[2, 1] == 'o' && connectGrid[3, 2] == 'o' && connectGrid[4, 3] == 'o' && connectGrid[5, 4] == 'o')

			|| (connectGrid[2, 0] == 'x' && connectGrid[3, 1] == 'x' && connectGrid[4, 2] == 'x' && connectGrid[5, 3] == 'x')
			|| (connectGrid[2, 0] == 'o' && connectGrid[3, 1] == 'o' && connectGrid[4, 2] == 'o' && connectGrid[5, 3] == 'o')

			|| (connectGrid[0, 1] == 'x' && connectGrid[1, 2] == 'x' && connectGrid[2, 3] == 'x' && connectGrid[3, 4] == 'x')
			|| (connectGrid[0, 1] == 'o' && connectGrid[1, 2] == 'o' && connectGrid[2, 3] == 'o' && connectGrid[3, 4] == 'o')
			|| (connectGrid[1, 2] == 'x' && connectGrid[2, 3] == 'x' && connectGrid[3, 4] == 'x' && connectGrid[4, 5] == 'x')
			|| (connectGrid[1, 2] == 'o' && connectGrid[2, 3] == 'o' && connectGrid[3, 4] == 'o' && connectGrid[4, 5] == 'o')

			|| (connectGrid[0, 2] == 'x' && connectGrid[1, 3] == 'x' && connectGrid[2, 4] == 'x' && connectGrid[3, 5] == 'x')
			|| (connectGrid[0, 2] == 'o' && connectGrid[1, 3] == 'o' && connectGrid[2, 4] == 'o' && connectGrid[3, 5] == 'o')

			|| (connectGrid[0, 3] == 'x' && connectGrid[1, 2] == 'x' && connectGrid[2, 1] == 'x' && connectGrid[3, 0] == 'x')
			|| (connectGrid[0, 3] == 'o' && connectGrid[1, 2] == 'o' && connectGrid[2, 1] == 'o' && connectGrid[3, 0] == 'o')

			|| (connectGrid[0, 4] == 'x' && connectGrid[1, 3] == 'x' && connectGrid[2, 2] == 'x' && connectGrid[3, 1] == 'x')
			|| (connectGrid[0, 4] == 'o' && connectGrid[1, 3] == 'o' && connectGrid[2, 2] == 'o' && connectGrid[3, 1] == 'o')
			|| (connectGrid[1, 3] == 'x' && connectGrid[2, 2] == 'x' && connectGrid[3, 1] == 'x' && connectGrid[4, 0] == 'x')
			|| (connectGrid[1, 3] == 'o' && connectGrid[2, 2] == 'o' && connectGrid[3, 1] == 'o' && connectGrid[4, 0] == 'o')

			|| (connectGrid[0, 5] == 'x' && connectGrid[1, 4] == 'x' && connectGrid[2, 3] == 'x' && connectGrid[3, 2] == 'x')
			|| (connectGrid[0, 5] == 'o' && connectGrid[1, 4] == 'o' && connectGrid[2, 3] == 'o' && connectGrid[3, 2] == 'o')
			|| (connectGrid[2, 3] == 'x' && connectGrid[3, 2] == 'x' && connectGrid[4, 1] == 'x' && connectGrid[5, 0] == 'x')
			|| (connectGrid[2, 3] == 'o' && connectGrid[3, 2] == 'o' && connectGrid[4, 1] == 'o' && connectGrid[5, 0] == 'o')

			|| (connectGrid[0, 6] == 'x' && connectGrid[1, 5] == 'x' && connectGrid[2, 4] == 'x' && connectGrid[3, 3] == 'x')
			|| (connectGrid[0, 6] == 'o' && connectGrid[1, 5] == 'o' && connectGrid[2, 4] == 'o' && connectGrid[3, 3] == 'o')
			|| (connectGrid[2, 4] == 'x' && connectGrid[3, 3] == 'x' && connectGrid[4, 2] == 'x' && connectGrid[5, 1] == 'x')
			|| (connectGrid[2, 4] == 'o' && connectGrid[3, 3] == 'o' && connectGrid[4, 2] == 'o' && connectGrid[5, 1] == 'o')

			|| (connectGrid[1, 6] == 'x' && connectGrid[2, 5] == 'x' && connectGrid[3, 4] == 'x' && connectGrid[4, 3] == 'x')
			|| (connectGrid[1, 6] == 'o' && connectGrid[2, 5] == 'o' && connectGrid[3, 4] == 'o' && connectGrid[4, 3] == 'o')
			|| (connectGrid[2, 5] == 'x' && connectGrid[3, 4] == 'x' && connectGrid[4, 3] == 'x' && connectGrid[5, 2] == 'x')
			|| (connectGrid[2, 5] == 'o' && connectGrid[3, 4] == 'o' && connectGrid[4, 3] == 'o' && connectGrid[5, 2] == 'o')

			|| (connectGrid[2, 6] == 'x' && connectGrid[3, 5] == 'x' && connectGrid[4, 4] == 'x' && connectGrid[5, 3] == 'x')
			|| (connectGrid[2, 6] == 'o' && connectGrid[3, 5] == 'o' && connectGrid[4, 4] == 'o' && connectGrid[5, 3] == 'o'))
				return true;
			return false;
		}
	}
}