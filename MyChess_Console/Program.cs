using MyChess_Library;
using System.Text;

Console.WriteLine("Hello, World!");

Board board = new Board();

board.FitPiecesOnBoard();
board.DrawSymbolsOnBoard();

Console.WriteLine("Please enter the current piece position: ");
string? currentPosition = Console.ReadLine();

Position currPos = new Position();
if(!string.IsNullOrEmpty(currentPosition) && currentPosition.Length is 2)
{
    int row = '8' - currentPosition[1];
    int col = (int)currentPosition[0] - 97;
    
    currPos.Row = row;
    currPos.Col = col;
    Console.WriteLine($"Row: {currPos.Row}\nCol: {currPos.Col}");
}
else
{
    Console.WriteLine("Please enter correct position, ex: e2");
}

Console.WriteLine("Please enter the current piece position: ");
string? newPosition = Console.ReadLine();

Position newPos = new Position();
if (!string.IsNullOrEmpty(newPosition) && newPosition.Length is 2)
{
    int row = '8' - newPosition[1];
    int col = (int)newPosition[0] - 97;
    
    newPos.Row = row;
    newPos.Col = col;
    Console.WriteLine($"Row: {newPos.Row}\nCol: {newPos.Col}");
}
else
{
    Console.WriteLine("Please enter correct position, ex: e2");
}

board.UpdateBoard(currPos, newPos);

//int a = 2;
//char b = 'b';
//int c = a - 8;
//Console.WriteLine(Math.Abs(c));
//Console.WriteLine((int)b - 97);