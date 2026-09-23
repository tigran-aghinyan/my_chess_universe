namespace MyChess_Library.Pieces;

public class Pawn : Piece
{
    public override PieceType Type
    {
        get => PieceType.Pawn;
    }
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
