using MyChess_Library;
using MyChess_Library.CustomExceptions;
using System.Text;

Board board = new Board();

board.FitPiecesOnBoard();
board.DrawSymbolsOnBoard();

Position currPos = new Position();

Console.WriteLine("Please enter the current piece position: ");
string? currentPosition = Console.ReadLine(); ;

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

    Console.WriteLine("Please enter correct current piece position.ex: e3");
    currentPosition = Console.ReadLine();
}

   

//Console.WriteLine("Please enter the piece new position: ");
//string? newPosition = Console.ReadLine();

//Position newPos = new Position();
//if (!string.IsNullOrEmpty(newPosition) && newPosition.Length is 2)
//{
//    newPos.Row = '8' - newPosition[1];
//    newPos.Col = (int)newPosition[0] - 97;

//    //Console.WriteLine($"Row: {newPos.Row}\nCol: {newPos.Col}");
//}
//else
//{
//    Console.WriteLine("Please enter correct position, ex: e2");
//}

//board.UpdateBoard(currPos, newPos);
