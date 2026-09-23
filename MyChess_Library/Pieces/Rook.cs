namespace MyChess_Library.Pieces;

public class Rook : Piece
{
    public override PieceType Type
    {
        get => PieceType.Rook;
    }
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
