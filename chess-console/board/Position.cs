namespace board
{
    public class Position
    {
        public int line { get; set; }
        public int column { get; set; }

        public Position(int linha, int coluna)
        {
            this.line = linha;
            this.column = coluna;
        }

        public override string ToString()
        {
            return line
                   + ", "
                   + column;
        }
    }
}