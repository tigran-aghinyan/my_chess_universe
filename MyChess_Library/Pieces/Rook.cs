namespace MyChess_Library.Pieces;

internal class Rook : Piece
{
    public PieceType type = PieceType.Rook;
    public Rook(string color) : base(color)
    {
        Color = color;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "R";
}
