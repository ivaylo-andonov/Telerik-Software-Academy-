namespace TeamProjectKoko
{
    using System;

    public interface IForm
    {

        int Row { get; set; }

        int Col { get; set; }

        char[,] Vision { get; set; }

        ConsoleColor Color { get; set; }

    }
}
