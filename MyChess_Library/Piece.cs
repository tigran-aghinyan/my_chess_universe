namespace MyChess_Library;

public abstract class Piece
{
    private string? _color;

    public abstract bool CanMove();
}
