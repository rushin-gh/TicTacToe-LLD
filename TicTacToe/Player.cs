namespace TicTacToe;

public class Player
{
    public string Name { get; set; }
    
    public Symbol PlayerSymbol { get; set; }

    public Player(string name, Symbol symbol)
    {
        Name = name;
        PlayerSymbol = symbol;
    }
}