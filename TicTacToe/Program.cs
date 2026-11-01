// Console.WriteLine("Hello, World!");
using TicTacToe;


string p1 = "X";
string p2 = "O";

int n = 3;
var gameManager = new GameManager(n, p1, p2);
gameManager.StartGame();

