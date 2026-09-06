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
        board[0, 0] = new Rook();
        board[0, 1] = new Knight();
        board[0, 2] = new Bishop();
        board[0, 3] = new Queen();
        board[0, 4] = new King();
        board[0, 5] = new Bishop();
        board[0, 6] = new Knight();
        board[0, 7] = new Rook();

        for (int i = 0; i < 8; i++)
            board[1, i] = new Pawn();

        for (int i = 0; i < 8; i++)
            board[6, i] = new Pawn();

        board[7, 0] = new Rook();
        board[7, 1] = new Knight();
        board[7, 2] = new Bishop();
        board[7, 3] = new King();
        board[7, 4] = new Queen();
        board[7, 5] = new Bishop();
        board[7, 6] = new Knight();
        board[7, 7] = new Rook();
    }

    public void DrawSymbolsOnBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                //if (j % 2 == 0)
                //{
                //    Console.Write(board[i, j].GetSymbol());
                //}
                //else
                //{
                //    Console.Write(" ");
                //}
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
}
