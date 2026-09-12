namespace MyChess_Library;

public abstract class Piece
{    
    private string? _color;
    private PieceType _type;
    private Position currPosition;
    public string Color { get; private set; }
    public PieceType Type { get; set; } // uxxel
    public Position CurrPosition { get; set; }
    public Piece() { }
    public Piece(string color)
    {
        Color = color;
    }

    public abstract string GetSymbol();
    public abstract bool CanMove();
}
