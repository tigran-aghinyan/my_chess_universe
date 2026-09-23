namespace MyChess_Library.Pieces;

public class Queen : Piece
{
    public override PieceType Type
    {
        get => PieceType.Queen;
    }
    public Queen(string color, Position position) : base(color, position)
    {
        Color = color;
        CurrPosition = position;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "Q";
}
