namespace MyChess_Library.Pieces;

internal class Knight : Piece
{
    public PieceType type = PieceType.Knight;
    public Knight(string color, Position position) : base(color, position)
    {
        Color = color;
        CurrPosition = position;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "N";
}
