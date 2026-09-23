using MyChess_Library.Pieces;

namespace MyChess_Library;

public class Board
{
    private Piece[,] board = new Piece[8, 8];

    public Piece this[int row, int column]
    {
        get => board[row, column];
        set => board[row, column] = value;
    }
    public void FitPiecesOnBoard()
    {
        board[0, 0] = new Rook("Black", new Position(0, 0));
        board[0, 1] = new Knight("Black", new Position(0, 1));
        board[0, 2] = new Bishop("Black", new Position(0, 2));
        board[0, 3] = new Queen("Black", new Position(0, 3));
        board[0, 4] = new King("Black", new Position(0, 4));
        board[0, 5] = new Bishop("Black", new Position(0, 5));
        board[0, 6] = new Knight("Black", new Position(0, 6));
        board[0, 7] = new Rook("Black", new Position(0, 7));

        for (int i = 0; i < 8; i++)
            board[1, i] = new Pawn("Black", new Position(1, i));

        for (int i = 0; i < 8; i++)
            board[6, i] = new Pawn("White", new Position(6, i));

        board[7, 0] = new Rook("White", new Position(7, 0));
        board[7, 1] = new Knight("White", new Position(7, 1));
        board[7, 2] = new Bishop("White", new Position(7, 2));
        board[7, 3] = new Queen("White", new Position(7, 3));
        board[7, 4] = new King("White", new Position(7, 4));
        board[7, 5] = new Bishop("White", new Position(7, 5));
        board[7, 6] = new Knight("White", new Position(7, 6));
        board[7, 7] = new Rook("White", new Position(7, 7));
    }

    public void DrawSymbolsOnBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if(board[i, j] == null)
                {
                    if(j != 7)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    if(j != 7)
                        Console.Write(board[i, j].GetSymbol() + " ");
                    else
                        Console.Write(board[i, j].GetSymbol());
                }
            }
            Console.WriteLine();
        }
    }

    public void UpdateBoard(Position currPosition, Position newPosition)
    {
        PieceType currentPiece = board[currPosition.Row, currPosition.Col].Type;
        Console.WriteLine(currentPiece);
        //board[newPosition.X, newPosition.Y] = new Pawn("Black", new Position(newPosition.X, newPosition.Y));
    }
}
