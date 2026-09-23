using MyChess_Library;
using MyChess_Library.CustomExceptions;
using System.Text;

Board board = new Board();

board.FitPiecesOnBoard();
board.DrawSymbolsOnBoard();

Position currPos = new Position();

Console.WriteLine("Please enter the current position of the piece: ");
string? currentPosition = Console.ReadLine();

while (true)
{
    if (currentPosition is null)
        return;
    if (currentPosition.Length == 2)
    {
        int currRow = '8' - currentPosition[1];
        int currCol = (int)currentPosition[0] - 97;

        if ((currRow >= 0 && currRow <= 7) && (currCol >= 0 && currCol <= 7))
        {
            if (board[currRow, currCol] is null)
            {
                Console.WriteLine("There is no piece here. Select another cell.");
                currentPosition = Console.ReadLine();
                continue;
            }
            else
            {
                currPos.Row = currRow;
                currPos.Col = currCol;
                break;
            }
        }
    }

    Console.WriteLine("Please enter correct position of the piece. ex: e3");
    currentPosition = Console.ReadLine();
}

Position newPos = new Position();

Console.WriteLine("Please enter the new position of the piece: ");
string? newPosition = Console.ReadLine();

while (true)
{
    if (newPosition is null)
        return;
    if (newPosition.Length == 2)
    {
        int newRow = '8' - newPosition[1];
        int newCol = (int)newPosition[0] - 97;

        if ((newRow >= 0 && newRow <= 7) && (newCol >= 0 && newCol <= 7))
        {
            newPos.Row = newRow;
            newPos.Col = newCol;
            break;
        }
    }

    Console.WriteLine("Please enter correct new position of the piece. ex: e3");
    newPosition = Console.ReadLine();
}

board.UpdateBoard(currPos, newPos);
