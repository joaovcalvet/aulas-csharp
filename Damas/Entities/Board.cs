namespace Damas.Entities;
using Enums;

class Board
{
    public const int LINES = 9;
    public const int COLUMNS = 9;
    private readonly Position[,] Positions;

    public Board()
    {
        Positions = new Position[8,8];
        StartBoard();
    }

    public void StartBoard()
    {
        bool jump = false;

        for(int line = 0; line < LINES-1; line++)
        {
            if(line % 2 != 0)
                jump = true;

            for (int column = 0; column < COLUMNS-1; column++)
            {
                if(line != 3 && line != 4)
                {
                    if(jump)
                    {
                        Positions[line, column] = new Position(line, column);
                        jump = false;
                        continue;
                    }

                    PieceColor clr = PieceColor.YELLOW;
                    if(line > 4)
                        clr = PieceColor.RED;

                    Positions[line, column] = new Position(line, column, new Piece(clr));
                    jump = true;
                    
                    continue;
                }

                Positions[line, column] = new Position(line, column);
            }
            jump = false;
        }
    }

    public Position GetPosition(int line, int column)
    {
        return Positions[line, column];
    }
}