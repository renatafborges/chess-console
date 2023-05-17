using board;
namespace chess

{
    public class Rock : Piece
    {
        public Rock(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}