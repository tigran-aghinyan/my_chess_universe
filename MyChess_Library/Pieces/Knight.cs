namespace MyChess_Library.Pieces;

internal class Knight : Piece
{
    public PieceType type = PieceType.Knight;
    public Knight(string color) : base(color)
    {
        Color = color;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "N";
}
