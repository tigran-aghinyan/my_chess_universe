namespace MyChess_Library.Pieces;

internal class Rook : Piece
{
    public PieceType type = PieceType.Rook;
    public Rook(string color, Position position) : base(color, position)
    {
        Color = color;
        CurrPosition = position;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "R";
}
