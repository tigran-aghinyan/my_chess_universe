namespace MyChess_Library.CustomExceptions;

public class InvalidPositionException : Exception
{
    public InvalidPositionException() : base("Entered position is not valid.") { }

    public InvalidPositionException(string message) : base(message)
    { }
}