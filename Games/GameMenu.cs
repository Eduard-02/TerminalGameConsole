namespace TerminalGameConsole.Games;

public class GameMenu
{
    public static void Menu(ref int a)
    {
        Console.WriteLine(
            "Welcome to the Game Menu! Choose one of the games to play:\n\n1 - Play Tic Tac Toe\n2 - Play Connect 4\n0 - Exit\n");
        a = int.Parse(Console.ReadLine());
    }
}