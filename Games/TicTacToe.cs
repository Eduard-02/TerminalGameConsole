namespace TerminalGameConsole.Games;

public class TicTacToe
{
    static char[,] toeGrid = new char[3, 3];
    static int toePlays = 9;
    static int player = 1;

    public static void Play()
    {
        Console.WriteLine("\nWelcome to the Tic Tac Toe game!\nHere is the grid! Player 1 - x and Player 2 - o.\n");

            //Initialize toeGrid to put white spaces
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    toeGrid[i, j] = ' ';
                }
            }

            // Write toeGrid with lines and columns
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(toeGrid[i, j]);
                    if (j < 2) Console.Write("|");
                }

                Console.WriteLine();
                if (i < 2) Console.WriteLine("-----");
            }

            while (toePlays != 0)
            {
                Console.WriteLine($"\nPlayer {player}, choose one line (0, 1, 2) and one column (0, 1, 2).");
                Console.Write("Line: ");
                int line = int.Parse(Console.ReadLine());
                Console.Write("Column: ");
                int column = int.Parse(Console.ReadLine());

                if (line >= 3 || column >= 3)
                {
                    Console.WriteLine($"Invalid move, try again!");
                    continue;
                }    
                
                if (toeGrid[line, column] == 'x' || toeGrid[line, column] == 'o')
                {
                    Console.WriteLine($"Invalid move, try again!");
                    continue;
                }

                if (player == 1)
                {
                    toeGrid[line, column] = 'x';
                    Console.Clear();
                    PrintGridToe();

                    if (CheckWinToe())
                    {
                        Console.WriteLine($"\nPLayer {player} wins!!!");
                        break;
                    }
                }
                else if (player == 2)
                {
                    toeGrid[line, column] = 'o';
                    Console.Clear();
                    PrintGridToe();

                    if (CheckWinToe())
                    {
                        Console.WriteLine($"\nPlayer {player} wins!!!");
                        break;
                    }
                }

                if (player == 1)
                    player++;
                else if (player == 2)
                    player--;
                toePlays--;
                
                if (toePlays == 0) 
                    Console.WriteLine("\nDraw");
            }
            
            static void PrintGridToe()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(toeGrid[i, j]);
                        if (j < 2) Console.Write("|");
                    }

                    Console.WriteLine();
                    if (i < 2) Console.WriteLine("-----");
                }
            }
            
            static bool CheckWinToe()
            {
                for (int i = 0; i < 3; i++)
                {
                    if ((toeGrid[i, 0] == 'x' && toeGrid[i, 1] == 'x' && toeGrid[i, 2] == 'x') ||
                        (toeGrid[i, 0] == 'o' && toeGrid[i, 1] == 'o' && toeGrid[i, 2] == 'o') ||
                        (toeGrid[0, i] == 'x' && toeGrid[1, i] == 'x' && toeGrid[2, i] == 'x') ||
                        (toeGrid[0, i] == 'o' && toeGrid[1, i] == 'o' && toeGrid[2, i] == 'o'))
                        return true;
                }

                if ((toeGrid[0, 0] == 'x' && toeGrid[1, 1] == 'x' && toeGrid[2, 2] == 'x') ||
                    (toeGrid[0, 0] == 'o' && toeGrid[1, 1] == 'o' && toeGrid[2, 2] == 'o') ||
                    (toeGrid[0, 2] == 'x' && toeGrid[1, 1] == 'x' && toeGrid[2, 0] == 'x') ||
                    (toeGrid[0, 2] == 'o' && toeGrid[1, 1] == 'o' && toeGrid[2, 0] == 'o'))
                    return true;
                return false;
            }
    }
}