namespace Minesweeper
{
    public class Score
    {
        public Score()
        {
        }

        public Score(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}