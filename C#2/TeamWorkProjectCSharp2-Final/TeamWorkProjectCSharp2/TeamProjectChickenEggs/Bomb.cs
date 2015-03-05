namespace TeamProjectKoko
{
    using System;

    public class Bomb : Form, IForm
    {
        public Bomb(int row, int col)
            : base(row, col)
        {
            this.Vision = new char[,]
            { 
                           
                            { ' ',' ', '!', ' ',' '}, 
                            { ' ','@' ,'@', '@' ,' '},
                            { 'B','O', 'O', 'M','B' },
                            { ' ','@', '@', '@',' ' }
            };
            
            this.Color = ConsoleColor.DarkRed;
        }
    }
}
