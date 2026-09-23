namespace MyChess_Library;

public abstract class Piece
{    
    public string Color { get; set; }
    public PieceType Type { get; set; } // uxxel
    public Position CurrPosition { get; set; }
    public Piece() { }
    public Piece(string color, Position currPosition)
    {
        Color = color;
        CurrPosition = currPosition;
    }

    public abstract string GetSymbol();

    public abstract bool CanMove();
}