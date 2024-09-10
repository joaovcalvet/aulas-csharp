using Damas.Entities.Enums;

namespace Damas.Entities;

class Piece
{
    public PieceColor Color {get; private set;}

    public Piece(PieceColor color)
    {
        Color = color;
    }
}