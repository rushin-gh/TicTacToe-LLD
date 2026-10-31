namespace TicTacToe;

public class GameManager
{
    private GameBoard _board;

    public Player[] players;

    public void InitialiseGame(int dimension, string p1, string p2)
    {
        _board = new GameBoard(dimension);
        players = new Player[2]
        {
            new Player(p1, Symbol.X),
            new Player(p2, Symbol.O)
        };
    }

    public void StartGame()
    {
        for (int i = 0; i < _board.Dimension * _board.Dimension; i++)
        {
            Player p = players[i % 2];
            do
            {
                int row = Convert.ToInt32(Console.ReadLine());
                int col = Convert.ToInt32(Console.ReadLine());
                if (_board.TryPlace(p, row, col))
                {
                    if (_board.WinCheck(p, row, col))
                    {
                        DisplayResult(p);
                        return;
                    }
                    else if (_board.DrawCheck())
                    {
                        DisplayResult(new Player("", Symbol._));
                        return;
                    }
                    break;
                }
            } while (true);
            
            
        }
    }

    public void DisplayResult(Player p)
    {
        if (p.PlayerSymbol == Symbol._)
        {
            // Print draw
        }
        else
        {
            // print p.Name
        }
    }
}