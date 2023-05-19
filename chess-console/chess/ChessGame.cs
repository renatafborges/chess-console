using board;

namespace chess
{
    public class ChessGame
    {
        public Board board { get; private set;}
        private int turn;
        private Color currentPlayer;
        public bool finished { get; private set;}

        public ChessGame()
        {
            board = new Board(8, 8);
            turn = 1;
            currentPlayer = Color.White;
            finished = false;
            InsertPieces();
        }

        public void MakeMove(Position origin, Position destination)
        {   Piece p = board.RemovePiece(origin);
            p.IncreaseMove();
            Piece CapturedPiece = board.RemovePiece(destination);
            board.InsertPiece(p, destination);
        }

        private void InsertPieces()
        {
            board.InsertPiece(new Rock(board, Color.White), new ChessPosition('c', 1).ToPosition());
            board.InsertPiece(new Rock(board, Color.White), new ChessPosition('c', 2).ToPosition());
            board.InsertPiece(new Rock(board, Color.White), new ChessPosition('d', 2).ToPosition());
            board.InsertPiece(new Rock(board, Color.White), new ChessPosition('e', 2).ToPosition());
            board.InsertPiece(new Rock(board, Color.White), new ChessPosition('e', 1).ToPosition());
            board.InsertPiece(new King(board, Color.White), new ChessPosition('d', 1).ToPosition());
            
            board.InsertPiece(new Rock(board, Color.Black), new ChessPosition('c', 7).ToPosition());
            board.InsertPiece(new Rock(board, Color.Black), new ChessPosition('c', 8).ToPosition());
            board.InsertPiece(new Rock(board, Color.Black), new ChessPosition('d', 7).ToPosition());
            board.InsertPiece(new Rock(board, Color.Black), new ChessPosition('e', 7).ToPosition());
            board.InsertPiece(new Rock(board, Color.Black), new ChessPosition('e', 8).ToPosition());
            board.InsertPiece(new King(board, Color.Black), new ChessPosition('d', 8).ToPosition());
        }
    }
}