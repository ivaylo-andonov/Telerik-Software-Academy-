namespace TeamProjectKoko
{
    using System;

    public class Shit : Form, IForm
    {
        public Shit(int row, int col, ConsoleColor color)
            : base(row, col)
        {
            this.Vision = new char[,]
            { 
                           { ' ', '@', ' ' }, 
                           { '@', '@', '@' } 
            };

            this.Color = color;
        }
    }
}
