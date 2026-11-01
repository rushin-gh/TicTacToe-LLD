namespace TicTacToe;

public class Player
{
    public string Name { get; private set; }
    
    public Symbol PlayerSymbol { get; private set; }

    public Player(string name, Symbol symbol)
    {
        Name = name;
        PlayerSymbol = symbol;
    }
}