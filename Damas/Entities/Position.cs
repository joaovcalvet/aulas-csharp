namespace Damas.Entities
{
    class Position
    {
        public int Line {get; private set;}
        public int Column {get; private set;}
        private readonly Piece? PositionPiece;

        public Position(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public Position(int line, int column, Piece piece)
        {
            Line = line;
            Column = column;
            PositionPiece = piece;
        }

        public Piece? CheckPosition()
        {
            return PositionPiece;
        }
    }
}