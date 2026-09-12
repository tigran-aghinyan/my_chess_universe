namespace MyChess_Library.Pieces;

internal class Pawn : Piece
{
    public PieceType type = PieceType.Pawn;
    public Pawn(string color, Position position) : base(color, position)
    {
        Color = color;
        CurrPosition = position;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "P";
}
