﻿using board;

namespace chess
{
    public class ChessPosition
    {
        public char column { get; private set; }
        public int line { get; set; }

        public ChessPosition(char column, int line)
        {
            this.column = column;
            this.line = line;
        }

        public Position ToPosition()
        {
            return new Position(8 - line, column - 'a');
        }
        
        public override string ToString()
        {
            return "" + column + line;
        }
    }
}