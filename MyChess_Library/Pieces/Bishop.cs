namespace MyChess_Library.Pieces;

public class Bishop : Piece
{
    public readonly PieceType type = PieceType.Bishop;
    public Bishop(string color, Position position) : base(color, position)
    {
        Color = color;
        CurrPosition = position;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "B";
}
