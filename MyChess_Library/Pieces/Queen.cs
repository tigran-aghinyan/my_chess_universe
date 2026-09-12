namespace MyChess_Library.Pieces;

internal class Queen : Piece
{
    public PieceType type = PieceType.Queen;
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
