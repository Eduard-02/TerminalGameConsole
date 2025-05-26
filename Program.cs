// Game Menu
// 1 - Play Tic Tac Toe
// 2 - Play 4 in a Row
// 3 - Calculator
// 0 - Exit
using TerminalGameConsole.Games;

namespace TerminalGameConsole
{
    class Program
    {
        static int choice = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                GameMenu.Menu(ref choice);

                switch (choice)
                {
                    case 0:
                        choice = 0;
                        Console.WriteLine("See you soon!");
                        return;
                    case 1:
                        choice = 1;
                        TicTacToe.Play();
                        break;
                    case 2:
                        choice = 2;
                        Connect4.InitializeGridConnect();
                        Connect4.Play();
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                Console.WriteLine("\nPlay another game? (y/n)");
                string again = Console.ReadLine();
                if (again != "y")
                {
                    Console.WriteLine("\nThank you for playing!");
                    break;
                }    
            }
        }
    }
}    