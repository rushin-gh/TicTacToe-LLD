namespace TicTacToe;

public class GameBoard
{
    public Symbol[,] Board { get; private set; }

    public int Dimension { get; }

    private int _diagonal { get; set; }
    private int _crossDiagonal { get; set; }
    
    private int[] _rowCheck { get; set; }
    private int[] colCheck { get; set; }
    
    
    public GameBoard(int dimension)
    {
        Dimension = dimension;
        Board = new Symbol[Dimension, Dimension];

        _diagonal = 0;
        _crossDiagonal = 0;
        _rowCheck = new int[Dimension];
        colCheck = new int[Dimension];
    }

    public bool IsValidMove(int row, int col)
    {
        return (row >= 0 && row < Dimension && col >= 0 && col < Dimension && Board[row, col] == Symbol.Empty);
    }

    public bool TryPlace(Player player, int row, int col)
    {

            Board[row, col] = player.PlayerSymbol;
            _rowCheck[row]++;
            colCheck[col]++;

            var v = (player.PlayerSymbol == Symbol.X ? 1 : -1);
            if (row == col)
            {
                _diagonal += v;
            }

            if (row + col == Dimension)
            {
                _crossDiagonal += v;
            }
            return true;
        
    }

    public bool WinCheck(int row, int col)
    {
        return (
            Math.Abs(_diagonal) == Dimension ||
            Math.Abs(_crossDiagonal) == Dimension ||
            Math.Abs(_rowCheck[row]) == Dimension ||
            Math.Abs(colCheck[col]) == Dimension
        );
    }

    public void PrintBoard()
    {
        // Print board
    }
}