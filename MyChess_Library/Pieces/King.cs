namespace MyChess_Library.Pieces;

internal class King : Piece
{
    public PieceType type = PieceType.King;
    public King(string color) : base(color)
    {
        Color = color;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "K";
}
