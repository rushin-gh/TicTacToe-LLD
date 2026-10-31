// Console.WriteLine("Hello, World!");
using TicTacToe;

var gameManager = new GameManager();


string p1 = "X";
string p2 = "O";

int n = 3;

gameManager.InitialiseGame(n, p1, p2);
gameManager.StartGame();

