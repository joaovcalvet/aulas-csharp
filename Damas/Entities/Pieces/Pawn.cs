using Damas.Entities.Enums;

namespace Damas.Entities.Pieces;

class Pawn : Piece
{
    public Pawn(PieceColor color):
    base(color){}

    public override string ToString()
    {
        return "P";
    }
}