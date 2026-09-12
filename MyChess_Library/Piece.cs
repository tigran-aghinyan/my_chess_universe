namespace MyChess_Library;

public abstract class Piece
{    
    private string? _color;
    private PieceType _type;
    private Position _currPosition;
    public string Color { get; set; }
    public PieceType Type { get; set; } // uxxel
    public Position CurrPosition { get; set; }
    public Piece() { }
    public Piece(string color, Position position)
    {
        Color = color;
        CurrPosition = position;
    }

    public abstract string GetSymbol();
    public abstract bool CanMove();
}
