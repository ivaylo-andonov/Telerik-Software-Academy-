namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {
        public static void Main()
        {
            const int MaxFieldsWithoutMine = 35;

            string currentCommand = string.Empty;
            char[,] field = CreateField();
            char[,] mines = PutMines();
            int pointsCounter = 0;
            int row = 0;
            int col = 0;
            bool isOnMine = false;
            bool isNewGame = true;
            bool isGameWon = false;
            List<Score> highscore = new List<Score>(6);

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper. Take your chance to find the fields without mines." +
                    "Command 'top' shows the highscore, 'restart' starts a new game, 'exit' stops the game!");
                    PrintPlayground(field);
                    isNewGame = false;
                }

                Console.Write("Enter a row and a column : ");
                currentCommand = Console.ReadLine().Trim();

                if (currentCommand.Length >= 3)
                {
                    if (int.TryParse(currentCommand[0].ToString(), out row) &&
                    int.TryParse(currentCommand[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        currentCommand = "turn";
                    }
                }

                switch (currentCommand)
                {
                    case "top":
                        GetHighscore(highscore);
                        break;
                    case "restart":
                        field = CreateField();
                        mines = PutMines();
                        PrintPlayground(field);
                        isOnMine = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good buy!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                MakeMove(field, mines, row, col);
                                pointsCounter++;
                            }

                            if (MaxFieldsWithoutMine == pointsCounter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                PrintPlayground(field);
                            }
                        }
                        else
                        {
                            isOnMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (isOnMine)
                {
                    PrintPlayground(mines);
                    string playerName = Console.ReadLine();
                    Score score = new Score(playerName, pointsCounter);

                    Console.Write("\nYou died like a hero with {0} points. " + "Write your name: ", pointsCounter);

                    if (highscore.Count < 5)
                    {
                        highscore.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < highscore.Count; i++)
                        {
                            if (highscore[i].Points < score.Points)
                            {
                                highscore.Insert(i, score);
                                highscore.RemoveAt(highscore.Count - 1);
                                break;
                            }
                        }
                    }

                    highscore.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    highscore.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    GetHighscore(highscore);

                    field = CreateField();
                    mines = PutMines();
                    pointsCounter = 0;
                    isOnMine = false;
                    isNewGame = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nGood job! You steped on 35 fields without succesfully!");
                    PrintPlayground(mines);

                    Console.WriteLine("Write your name: ");
                    string playerName = Console.ReadLine();
                    Score score = new Score(playerName, pointsCounter);

                    highscore.Add(score);
                    GetHighscore(highscore);
                    field = CreateField();
                    mines = PutMines();
                    pointsCounter = 0;
                    isGameWon = false;
                    isNewGame = true;
                }
            }
            while (currentCommand != "exit");
            Console.WriteLine("Thanks for playing !");
            Console.Read();
        }

        private static void GetHighscore(List<Score> score)
        {
            Console.WriteLine("\nScore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, score[i].Name, score[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Highscore is empty!\n");
            }
        }

        private static void MakeMove(char[,] playGround, char[,] minesField, int row, int col)
        {
            char minesCount = CountMines(minesField, row, col);
            minesField[row, col] = minesCount;
            playGround[row, col] = minesCount;
        }

        private static void PrintPlayground(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playground = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playground[i, j] = '-';
                }
            }

            List<int> randomMines = new List<int>();
            while (randomMines.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!randomMines.Contains(asfd))
                {
                    randomMines.Add(asfd);
                }
            }

            foreach (int bombs in randomMines)
            {
                int col = bombs / columns;
                int row = bombs % columns;

                if (row == 0 && bombs != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playground[col, row - 1] = '*';
            }

            return playground;
        }

        private static void CalculateFieldValue(char[,] pole)
        {
            int col = pole.GetLength(0);
            int row = pole.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char minesCounter = CountMines(pole, i, j);
                        pole[i, j] = minesCounter;
                    }
                }
            }
        }

        private static char CountMines(char[,] playground, int row, int col)
        {
            int count = 0;
            int rows = playground.GetLength(0);
            int cols = playground.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playground[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (playground[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playground[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (playground[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playground[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playground[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playground[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playground[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
