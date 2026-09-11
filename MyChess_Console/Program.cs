using MyChess_Library;
using System.Text;

Console.WriteLine("Hello, World!");

Board board = new Board();

board.FitPiecesOnBoard();
board.DrawSymbolsOnBoard();

Console.WriteLine("Please enter the current piece position: ");
string? currentPosition = Console.ReadLine();

if(!string.IsNullOrEmpty(currentPosition) && currentPosition.Length is 2)
{
    int currX = (int)currentPosition[0] - 97;
    int currY = '8' - currentPosition[1];
    Console.WriteLine($"X: {currX}\nY: {currY}");
}
else
{
    Console.WriteLine("Please enter correct position, ex: e2");
}

Console.WriteLine("Please enter the current piece position: ");
string? newPosition = Console.ReadLine();

if (!string.IsNullOrEmpty(newPosition) && newPosition.Length is 2)
{
    int newX = (int)newPosition[0] - 97;
    int newY = '8' - newPosition[1];
    Console.WriteLine($"X: {newX}\nY: {newY}");
}
else
{
    Console.WriteLine("Please enter correct position, ex: e2");
}

//int a = 2;
//char b = 'b';
//int c = a - 8;
//Console.WriteLine(Math.Abs(c));
//Console.WriteLine((int)b - 97);