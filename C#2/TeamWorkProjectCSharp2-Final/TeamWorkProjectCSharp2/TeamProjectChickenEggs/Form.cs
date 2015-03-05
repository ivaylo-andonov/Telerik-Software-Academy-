namespace TeamProjectKoko
{
    using System;

    public class Form : IForm
    {
        private int row;
        private int col;
        private char[,] vision;
        private ConsoleColor color;

        public Form()
        {
            this.Row = row;
            this.Col = col;
        }

        public Form(int row, int col) :base()
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }

        public char[,] Vision
        {
            get
            {
                return this.vision;
            }
             set
            {
                this.vision = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
             set
            {
                this.color = value;
            }
        }
    }
}
