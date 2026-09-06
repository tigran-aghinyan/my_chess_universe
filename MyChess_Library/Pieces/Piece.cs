namespace MyChess_Library.Pieces;

public abstract class Piece
{

    private string? _color;

    public abstract string GetSymbol();
    public abstract bool CanMove();
}
