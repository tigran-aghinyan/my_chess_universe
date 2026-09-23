namespace MyChess_Library.Pieces;

public class King : Piece
{
    public override PieceType Type
    {
        get => PieceType.King;
    }
    public King(string color, Position position) : base(color, position)
    {
        Color = color;
        CurrPosition = position;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "K";
}
