namespace MyChess_Library.Pieces;

internal class Pawn : Piece
{
    //public Position X;
    //public Position Y;

    //public Pawn(Position x, Position y)
    //{
    //    X = x;
    //    Y = y;
    //}

    public PieceType type = PieceType.Pawn;
    public Pawn(string color) : base(color)
    {
        Color = color;
    }
    public override bool CanMove()
    {
        throw new NotImplementedException();
    }

    public override string GetSymbol() => "P";
}
