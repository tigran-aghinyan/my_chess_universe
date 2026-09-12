namespace MyChess_Library.Pieces;

internal class Queen : Piece
{
    public PieceType type = PieceType.Queen;
    public Queen(string color) : base(color)
    {
        Color = color;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "Q";
}
