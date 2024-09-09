using Damas.Entities;
using Damas.Entities.Enums;

namespace Damas.Renderer;

static class BoardRender
{
    private static string[] FixedLines = {"A", "B", "C", "D", "E", "F", "G", "H"};
    private static string[] FixedColumns = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};

    public static void BoardRendering(Board board)
    {
        for (int line = 0; line < Board.LINES; line++)
        {
            if(line != 8)
                Console.Write(FixedLines[line] + " ");
            else
                Console.Write("  ");

            for (int column = 1; column < Board.COLUMNS; column++)
            {
                if(line == 8)
                {
                    Console.Write(FixedColumns[column] + " ");
                    continue;
                }

                Piece? piece = board.GetPosition(line, column - 1).CheckPosition(); 

                if(piece != null)
                {
                    switch (piece.Color)
                    {
                        case PieceColor.YELLOW:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case PieceColor.RED:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }

                    Console.Write(piece.ToString() + " ", Console.ForegroundColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                Console.Write("- ");
            }
            Console.WriteLine();
        }
    }
}