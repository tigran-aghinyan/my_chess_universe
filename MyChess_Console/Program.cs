using MyChess_Library;
using MyChess_Library.CustomExceptions;
using System.Text;

Board board = new Board();

board.FitPiecesOnBoard();
board.DrawSymbolsOnBoard();

Console.WriteLine("Please enter the current piece position: ");
string? currentPosition = Console.ReadLine();

Position currPos = new Position();

try
{
    if (!string.IsNullOrEmpty(currentPosition)) //kisat
    {
        int currRow = '8' - currentPosition[1];
        int currCol = (int)currentPosition[0] - 97;

        currPos.Row = currRow;
        currPos.Col = currCol;
        //Console.WriteLine($"Row: {currPos.Row}\nCol: {currPos.Col}");
    }
    else
    {
        Console.WriteLine("Please enter correct piece position.ex: e3");
    }

}
catch (InvalidPositionException exp)
{
    Console.WriteLine($"Exception: {exp.Message}");
}


Console.WriteLine("Please enter the piece new position: ");
string? newPosition = Console.ReadLine();

Position newPos = new Position();
if (!string.IsNullOrEmpty(newPosition) && newPosition.Length is 2)
{
    newPos.Row = '8' - newPosition[1];
    newPos.Col = (int)newPosition[0] - 97;
  
    //Console.WriteLine($"Row: {newPos.Row}\nCol: {newPos.Col}");
}
else
{
    Console.WriteLine("Please enter correct position, ex: e2");
}

board.UpdateBoard(currPos, newPos);
