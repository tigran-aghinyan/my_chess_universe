namespace MyChess_Library.Pieces;

public class Bishop : Piece
{
    public PieceType type = PieceType.Bishop;
    public Bishop(string color) : base(color)
    {
        Color = color;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "B";
}
