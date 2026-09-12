namespace MyChess_Library.Pieces;

internal class King : Piece
{
    public PieceType type = PieceType.King;
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
