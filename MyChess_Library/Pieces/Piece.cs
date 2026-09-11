namespace MyChess_Library.Pieces;

public abstract class Piece
{
    public Position X;
    public Position Y;
    
    private string? _color;

    public abstract string GetSymbol();
    public abstract bool CanMove();
}
