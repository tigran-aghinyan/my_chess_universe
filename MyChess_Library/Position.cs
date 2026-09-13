namespace MyChess_Library;

public struct Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position() { }
    public Position(int newX, int newY)
    {
        X = newX;
        Y = newY;
    }
}
