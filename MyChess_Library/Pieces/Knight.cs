namespace MyChess_Library.Pieces;

public class Knight : Piece
{
    public override PieceType Type
    {
        get => PieceType.Knight;
    }
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
