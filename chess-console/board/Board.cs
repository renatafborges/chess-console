namespace board
{
    public class Board
    {
        public int lines { get; set; }
        public int columns { get; set;  }
        private Piece[,] pieces;

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }
        
        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }
        
        private Piece piece(Position position)
        {
            return pieces[position.line, position.column];
        }

        private bool ContainsPiece(Position position)
        {
            ValidatePosition(position);
            return piece(position) != null;
        }
        
        public void InsertPiece(Piece p, Position pos)
        {
            if (ContainsPiece(pos))
            {
                throw new BoardException("There is already a piece in this position");
            }
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }

        private bool ValidPosition(Position position)
        {
                if (position.line < 0 || position.line >= lines || position.column < 0 || position.column >= columns)
                {
                    return false;
                }
                return true;
        }

        private void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid Position");
            }
        }
    }
}