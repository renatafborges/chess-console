using System;
using board;
using chess;
using System.Xml;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame chessGame = new ChessGame();

                while (!chessGame.finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(chessGame.board);

                    Console.WriteLine();
                    Console.WriteLine("Insert piece origin:");
                    Position origin = Screen.ReadChessPosition().ToPosition();
                    Console.WriteLine("Insert piece destination:");
                    Position destination = Screen.ReadChessPosition().ToPosition();
                    
                    chessGame.MakeMove(origin, destination);
                }
            }
            catch (BoardException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }
    }
}