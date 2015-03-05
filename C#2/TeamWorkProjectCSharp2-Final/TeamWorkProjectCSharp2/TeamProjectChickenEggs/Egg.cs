namespace TeamProjectKoko
{
    using System;

    public class Egg : Form, IForm
    {
        public Egg(int row, int col)
            : base(row, col)
        {
            this.Color = ConsoleColor.White;
            this.Vision = new char[,]
            { 
                    { ' ',' ', '_', ' ',' '}, 
                    { ' ','/', '@', '\\',' '}, 
                    { '|','@' ,'^', '@' ,'|'},
                    { '\\','^', '@', '^','/' },
                    { ' ','\'', '-', '\'',' ' }
            };
        }
    }
}
