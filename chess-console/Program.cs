using System;
using board;
using chess;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);
            
                board.InsertPiece(new Rock(board, Color.Black), new Position(0, 0));
                board.InsertPiece(new Rock(board, Color.Black), new Position(1, 3));
                board.InsertPiece(new King(board, Color.Black), new Position(0, 2));
                
                board.InsertPiece(new King(board, Color.White), new Position(3, 5));

                Screen.PrintBoard(board);
                Console.ReadLine();
            }
            catch (BoardException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            Console.ReadLine();
        }
    }
}