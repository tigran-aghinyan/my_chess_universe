namespace MyChess_Library;

public struct Position
{
    public int Row { get; set; } // y
    public int Col { get; set; } // x

    public Position() { }
    public Position(int row, int col)
    {
        Row = row;
        Col = col;
    }
}
