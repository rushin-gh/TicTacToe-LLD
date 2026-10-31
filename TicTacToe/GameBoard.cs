namespace TicTacToe;

public class GameBoard
{
    public Symbol[,] Board { get; }

    public int Dimension { get; set; }

    public GameBoard(int dimension)
    {
        Dimension = dimension;
        Board = new Symbol[Dimension, Dimension];

        for (int i = 0; i < Dimension; i++)
        {
            for (int j = 0; j < Dimension; j++)
            {
                Board[i, j] = Symbol._;
            }
        }
    }

    public bool TryPlace(Player P, int row, int col)
    {
        if (Board[row, col] != Symbol._)
        {
            return false;
        }

        Board[row, col] = P.PlayerSymbol;
        return true;
    }

    public bool WinCheck(Player P, int row, int col)
    {
        // Check row, col, diagonal and cross diagonal based on that send result;
        // Sending true temporarily
        return true;
    }

    public bool DrawCheck()
    {
        // Check if there is no such move that will result to win of one player
        // Sending true temporaily
        return true;
    }

    public void PrintBoard()
    {
        // Print board
    }
}