using Damas.Entities.Enums;

namespace Damas.Entities.Pieces;

class Queen : Piece
{
    public Queen(PieceColor color):
    base(color){}

    public override string ToString()
    {
        return "Q";
    }
}