namespace TicTacToe;

public class GameManager
{
    private GameBoard _board;

    private Player[] _players;

    public GameManager(int dimension, string p1, string p2)
    {
        _board = new GameBoard(dimension);
        _players = new Player[2]
        {
            new Player(p1, Symbol.X),
            new Player(p2, Symbol.O)
        };
    }

    public void StartGame()
    {
        for (int i = 0; i < _board.Dimension * _board.Dimension; i++)
        {
            Player p = _players[i % 2];
            do
            {
                var rowInput = Console.ReadLine();
                var colInput = Console.ReadLine();

                if (int.TryParse(rowInput, out int row) && int.TryParse(colInput, out int col))
                {
                    row--;
                    col--;
                    if (_board.IsValidMove(row, col) && _board.TryPlace(p, row, col) && _board.WinCheck(row, col))
                    {
                        DisplayResult(GameResult.Win, p);
                        return;
                    }
                }
            } while (true);
        }
        DisplayResult(GameResult.Draw);
    }

    public void DisplayResult(GameResult result, Player p = null)
    {
        if (result == GameResult.Draw)
        {
            Console.WriteLine("Game drawn");
        }
        else
        {
            if (p == null)
            {
                throw new Exception("For win result player cant be null");
            }

            Console.WriteLine($"Winner : {p.Name}");
        }
        
    }
}