namespace MyChess_Library;

public class Board
{
    public void DrawDotsOnBoard()
    {
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 16; j++)
            {
                if(j % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
