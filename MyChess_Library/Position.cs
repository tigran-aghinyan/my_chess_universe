using MyChess_Library.CustomExceptions;

namespace MyChess_Library;

public struct Position
{
    private int _row;
    private int _col;

    public int Row
    {
        get => _row;
        set
        {
            if (value < 0 || value > 7)
                throw new InvalidPositionException();

            _row = value;
            
        }
    }

    public int Col 
    { 
        get => _col; 
        set
        {
            if (value < 0 || value > 7)
                throw new InvalidPositionException();

            _col = value;
        }
    }

    public Position() { }
    public Position(int row, int col)
    {
        Row = row;
        Col = col;
    }
}
