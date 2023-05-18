using System;
using board;
using chess;
using System.Threading.Channels;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosition());
        }
    }
}