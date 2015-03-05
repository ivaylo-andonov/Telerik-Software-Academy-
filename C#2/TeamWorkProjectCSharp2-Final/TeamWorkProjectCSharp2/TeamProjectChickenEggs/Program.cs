namespace TeamProjectKoko
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;

    class ChickenEggs
    {
        static readonly Random rnd = new Random();


        static List<IForm> falliingThings = new List<IForm>();
        static int forms = 4;

        static PlayerPosition player = new PlayerPosition();
        // default
        static uint score = 0;
        static int thingFallSpeed = 120;
        static int speedForPrint = 200;
        static byte playerMoveSteps = 5;
        static int lives = 3;
        static string name = string.Empty;


        // setting game width
        static int placeForScore = 30;
        static int playWidth = (Console.WindowWidth - 1) - placeForScore;
        static bool[,] freePositions = new bool[14, playWidth + 1];

        static void Main()
        {
            Anime.PrintAnimation();
            Console.OutputEncoding = Encoding.GetEncoding(1252);
            SetStartPositions();
            PrintBorder();
            PrintChiken();

            while (true)
            {
                Clear(2, 7, playWidth + 2, Console.WindowHeight - 7);
                InitiallyAddingThings();
                freePositions = new bool[13, playWidth];
                PrintForms(falliingThings);
                MoveBasket();

                for (int i = falliingThings.Count - 1; i >= 0; i--)
                {
                    falliingThings[i].Row++;
                    if (falliingThings[i].Color == ConsoleColor.White && CheckEgg(falliingThings[i], player.y, player.x))
                    {
                        score += 20;
                        falliingThings.Remove(falliingThings[i]);
                    }
                    else if (falliingThings[i].Color == ConsoleColor.DarkRed && CheckBomb(falliingThings[i], player.y, player.x))
                    {
                        lives--;
                        thingFallSpeed = 120;
                        speedForPrint = 200;
                        PrintBasket();
                        falliingThings.Clear();
                        if (lives == 0)
                        {
                            Beep(3);
                            PrintDeathChiken();
                            Entrance();
                        }

                        break;
                    }
                    else if (falliingThings[i].Color == ConsoleColor.Green && CheckShit(falliingThings[i], player.y, player.x))
                    {
                        thingFallSpeed -= 20;
                        speedForPrint += 20;
                        falliingThings.Remove(falliingThings[i]);
                    }
                    else if (falliingThings[i].Color == ConsoleColor.Magenta && CheckShit(falliingThings[i], player.y, player.x))
                    {
                        thingFallSpeed += 20;
                        speedForPrint -= 20;
                        falliingThings.Remove(falliingThings[i]);
                    }

                    if (thingFallSpeed < 20)
                    {
                        thingFallSpeed = 20;
                    }
                    if (thingFallSpeed > 200)
                    {
                        thingFallSpeed = 200;
                    }
                }

                PrintBasket();


                // printing lives and score
                //PrintOnPosition(22, 5, ("Lives: " + livesCount), ConsoleColor.Green);  - towa tuk go nqma
                PrintOnPosition(playWidth + 7, 10, ("SPEED  - " + speedForPrint + "KM/H"), ConsoleColor.White, ConsoleColor.Red);
                PrintOnPosition(playWidth + 7, 14, ("YOUR SCORE: " + score), ConsoleColor.White, ConsoleColor.Red);
                PrintOnPosition(playWidth + 7, 18, ("LIVES LEFT: " + lives), ConsoleColor.White, ConsoleColor.Red);

                //slow down
                Thread.Sleep(thingFallSpeed);

            }

        }

        private static bool CheckEgg(IForm form, int playerCol, int playerRow)
        {
            if (form.Row + 3 == playerRow)
            {
                if (form.Col + 1 == playerCol || form.Col + 1 == playerCol + 1 ||
                    form.Col + 1 == playerCol + 2 || form.Col + 1 == playerCol + 3 ||
                    form.Col + 1 == playerCol + 4 || form.Col + 1 == playerCol + 5 ||
                    form.Col + 1 == playerCol + 6 || form.Col + 1 == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 2 == playerCol || form.Col + 2 == playerCol + 1 ||
                    form.Col + 2 == playerCol + 2 || form.Col + 2 == playerCol + 3 ||
                    form.Col + 2 == playerCol + 4 || form.Col + 2 == playerCol + 5 ||
                     form.Col + 2 == playerCol + 6 || form.Col + 2 == playerCol + 8)
                {
                    return true;
                }

                if (form.Col + 3 == playerCol || form.Col + 3 == playerCol + 1 ||
                    form.Col + 3 == playerCol + 2 || form.Col + 3 == playerCol + 3 ||
                    form.Col + 3 == playerCol + 4 || form.Col + 3 == playerCol + 5 ||
                     form.Col + 3 == playerCol + 6 || form.Col + 3 == playerCol + 7)
                {
                    return true;
                }

            }

            if (form.Row + 2 == playerRow)
            {
                if (form.Col == playerCol || form.Col == playerCol + 1 ||
                    form.Col == playerCol + 2 || form.Col == playerCol + 3 ||
                    form.Col == playerCol + 4 || form.Col == playerCol + 5 ||
                     form.Col == playerCol + 6 || form.Col == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 4 == playerCol || form.Col + 4 == playerCol + 1 ||
                    form.Col + 4 == playerCol + 2 || form.Col + 4 == playerCol + 3 ||
                    form.Col + 4 == playerCol + 4 || form.Col + 4 == playerCol + 5 ||
                     form.Col + 4 == playerCol + 6 || form.Col + 4 == playerCol + 7)
                {
                    return true;
                }
            }

            if (form.Row + 1 == playerRow)
            {
                if (form.Col == playerCol || form.Col == playerCol + 1 ||
                    form.Col == playerCol + 2 || form.Col == playerCol + 3 ||
                    form.Col == playerCol + 4 || form.Col == playerCol + 5 ||
                     form.Col == playerCol + 6 || form.Col == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 4 == playerCol || form.Col + 4 == playerCol + 1 ||
                    form.Col + 4 == playerCol + 2 || form.Col + 4 == playerCol + 3 ||
                    form.Col + 4 == playerCol + 4 || form.Col + 4 == playerCol + 5 ||
                     form.Col + 4 == playerCol + 6 || form.Col + 4 == playerCol + 7)
                {
                    return true;
                }
            }

            if (form.Row == playerRow)
            {
                if (form.Col + 1 == playerCol || form.Col + 1 == playerCol + 1 ||
                    form.Col + 1 == playerCol + 2 || form.Col + 1 == playerCol + 3 ||
                    form.Col + 1 == playerCol + 4 || form.Col + 1 == playerCol + 5 ||
                    form.Col + 1 == playerCol + 6 || form.Col + 1 == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 2 == playerCol || form.Col + 2 == playerCol + 1 ||
                    form.Col + 2 == playerCol + 2 || form.Col + 2 == playerCol + 3 ||
                    form.Col + 2 == playerCol + 4 || form.Col + 2 == playerCol + 5 ||
                     form.Col + 2 == playerCol + 6 || form.Col + 2 == playerCol + 8)
                {
                    return true;
                }

                if (form.Col + 3 == playerCol || form.Col + 3 == playerCol + 1 ||
                    form.Col + 3 == playerCol + 2 || form.Col + 3 == playerCol + 3 ||
                    form.Col + 3 == playerCol + 4 || form.Col + 3 == playerCol + 5 ||
                     form.Col + 3 == playerCol + 6 || form.Col + 3 == playerCol + 7)
                {
                    return true;
                }

            }

            return false;
        }

        private static bool CheckShit(IForm form, int playerCol, int playerRow)
        {
            if (form.Row == playerRow)
            {
                if (form.Col == playerCol || form.Col == playerCol + 1 ||
                    form.Col == playerCol + 2 || form.Col == playerCol + 3 ||
                    form.Col == playerCol + 4 || form.Col == playerCol + 5 ||
                     form.Col == playerCol + 6 || form.Col == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 1 == playerCol || form.Col + 1 == playerCol + 1 ||
                    form.Col + 1 == playerCol + 2 || form.Col + 1 == playerCol + 3 ||
                    form.Col + 1 == playerCol + 4 || form.Col + 1 == playerCol + 5 ||
                    form.Col + 1 == playerCol + 6 || form.Col + 1 == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 2 == playerCol || form.Col + 2 == playerCol + 1 ||
                    form.Col + 2 == playerCol + 2 || form.Col + 2 == playerCol + 3 ||
                    form.Col + 2 == playerCol + 4 || form.Col + 2 == playerCol + 5 ||
                     form.Col + 2 == playerCol + 6 || form.Col + 2 == playerCol + 8)
                {
                    return true;
                }

            }

            if (form.Row - 1 == playerRow)
            {
                if (form.Col + 1 == playerCol || form.Col + 1 == playerCol + 1 ||
                   form.Col + 1 == playerCol + 2 || form.Col + 1 == playerCol + 3 ||
                   form.Col + 1 == playerCol + 4 || form.Col + 1 == playerCol + 5 ||
                   form.Col + 1 == playerCol + 6 || form.Col + 1 == playerCol + 7)
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintBasket()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(player.y, player.x);

            if (player.y < 2)
            {
                Console.SetCursorPosition(2, player.x);
            }
            Console.Write("\\\\____//");
        }

        private static bool CheckBomb(IForm form, int playerCol, int playerRow)
        {

            if (form.Row + 2 == playerRow)
            {
                if (form.Col + 1 == playerCol || form.Col + 1 == playerCol + 1 ||
                    form.Col + 1 == playerCol + 2 || form.Col + 1 == playerCol + 3 ||
                    form.Col + 1 == playerCol + 4 || form.Col + 1 == playerCol + 5 ||
                    form.Col + 1 == playerCol + 6 || form.Col + 1 == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 2 == playerCol || form.Col + 2 == playerCol + 1 ||
                    form.Col + 2 == playerCol + 2 || form.Col + 2 == playerCol + 3 ||
                    form.Col + 2 == playerCol + 4 || form.Col + 2 == playerCol + 5 ||
                     form.Col + 2 == playerCol + 6 || form.Col + 2 == playerCol + 8)
                {
                    return true;
                }

                if (form.Col + 3 == playerCol || form.Col + 3 == playerCol + 1 ||
                    form.Col + 3 == playerCol + 2 || form.Col + 3 == playerCol + 3 ||
                    form.Col + 3 == playerCol + 4 || form.Col + 3 == playerCol + 5 ||
                     form.Col + 3 == playerCol + 6 || form.Col + 3 == playerCol + 7)
                {
                    return true;
                }

            }

            if (form.Row + 1 == playerRow)
            {
                if (form.Col == playerCol || form.Col == playerCol + 1 ||
                    form.Col == playerCol + 2 || form.Col == playerCol + 3 ||
                    form.Col == playerCol + 4 || form.Col == playerCol + 5 ||
                     form.Col == playerCol + 6 || form.Col == playerCol + 7)
                {
                    return true;
                }

                if (form.Col + 4 == playerCol || form.Col + 4 == playerCol + 1 ||
                    form.Col + 4 == playerCol + 2 || form.Col + 4 == playerCol + 3 ||
                    form.Col + 4 == playerCol + 4 || form.Col + 4 == playerCol + 5 ||
                     form.Col + 4 == playerCol + 6 || form.Col + 4 == playerCol + 7)
                {
                    return true;
                }
            }

            if (form.Row == playerRow)
            {
                if (form.Col + 1 == playerCol || form.Col + 1 == playerCol + 1 ||
                    form.Col + 1 == playerCol + 2 || form.Col + 1 == playerCol + 3 ||
                    form.Col + 1 == playerCol + 4 || form.Col + 1 == playerCol + 5 ||
                     form.Col + 1 == playerCol + 6 || form.Col + 1 == playerCol + 7)
                {
                    return true;
                }


                if (form.Col + 3 == playerCol || form.Col + 3 == playerCol + 1 ||
                    form.Col + 3 == playerCol + 2 || form.Col + 3 == playerCol + 3 ||
                    form.Col + 3 == playerCol + 4 || form.Col + 3 == playerCol + 5 ||
                     form.Col + 3 == playerCol + 6 || form.Col + 3 == playerCol + 7)
                {
                    return true;
                }
            }

            if (form.Row - 1 == playerRow)
            {
                if (form.Col + 2 == playerCol || form.Col + 2 == playerCol + 1 ||
                    form.Col + 2 == playerCol + 2 || form.Col + 2 == playerCol + 3 ||
                    form.Col + 2 == playerCol + 4 || form.Col + 2 == playerCol + 5 ||
                     form.Col + 2 == playerCol + 6 || form.Col + 2 == playerCol + 7)
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintForms(List<IForm> falliingThings)
        {
            for (int i = 0; i < falliingThings.Count; i++)
            {
                Print(falliingThings[i].Vision, falliingThings[i].Row, falliingThings[i].Col, falliingThings[i].Color);
            }

        }

        private static void MoveBasket()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo userKey = Console.ReadKey(true);

                if (userKey.Key == ConsoleKey.LeftArrow && player.y > 2)
                {
                    player = new PlayerPosition(player.x, player.y - (playerMoveSteps - 1));
                }
                else if (userKey.Key == ConsoleKey.RightArrow && player.y + 6 < playWidth)
                {
                    player = new PlayerPosition(player.x, player.y + (playerMoveSteps - 1));
                }
            }
        }

        private static void SetStartPositions()
        {
            ConsoleOptions();

            EnterName();
            // Set player's start position
            player = new PlayerPosition(Console.WindowHeight - 1, playWidth / 2 - 3);
            playerMoveSteps = 5;
        }

        static void PrintChiken()
        {
            char[,] chicken = { 
                                { ' ', ' ', ' ','_', '_', '/', '/', ' ', ' ' },
                                { ' ', ' ', '/', '.','_', '_' , '.', '\\', ' ' },
                                { ' ',' ','\\', ' ', '\\','/', ' ' ,'/', ' '},
                                { '_', '_','/', ' ', ' ',' ', ' ' ,'\\', ' '},
                                { '\\', '-',' ', ' ', ' ',' ', ' ' ,' ', ')' },
                                { ' ', '\\',' ', ' ', ' ',' ', ' ' ,'/', ' ' },
                                { ' ', ' ', '\\', '_', '_','_','/', ' ', ' ' }
                                   };

            Print(chicken, 0, 1, ConsoleColor.Yellow);
            Print(chicken, 0, 12, ConsoleColor.Yellow);
            Print(chicken, 0, 23, ConsoleColor.Yellow);
            Print(chicken, 0, 34, ConsoleColor.Yellow);
            Print(chicken, 0, 45, ConsoleColor.Yellow);
        }

        static void PrintDeathChiken()
        {
            char[,] chicken = { 
                                { ' ', ' ', ' ','_', '_', '\\', '\\', ' ', ' ' },
                                { ' ', ' ', '/', 'x',' ', ' ' , 'x', '\\', ' ' },
                                { ' ',' ','\\', ' ', '(',')', ' ' ,'/', ' '},
                                { '_', '_','/', ' ', ' ',' ', ' ' ,'\\', ' '},
                                { '\\', '-',' ', '\\', '/',' ', ' ' ,' ', ')' },
                                { ' ', '\\',' ', '/', '\\',' ', ' ' ,'/', ' ' },
                                { ' ', ' ', '\\', '_', '_','_','/', ' ', ' ' }
                                   };

            Print(chicken, 0, 1, ConsoleColor.Red);
            Print(chicken, 0, 12, ConsoleColor.Red);
            Print(chicken, 0, 23, ConsoleColor.Red);
            Print(chicken, 0, 34, ConsoleColor.Red);
            Print(chicken, 0, 45, ConsoleColor.Red);
        }

        private static void PrintBorder()
        {
            for (int i = 8; i < Console.BufferHeight; i++)
            {
                PrintOnPosition(playWidth + 4, i, ("()"), ConsoleColor.Cyan, ConsoleColor.Black);
            }
            for (int i = 8; i < Console.BufferHeight; i++)
            {
                PrintOnPosition(0, i, ("()"), ConsoleColor.Cyan, ConsoleColor.Black);
            }
        }

        static void PrintOnPosition(int x, int y, string str, ConsoleColor colorOne, ConsoleColor colorTwo)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colorOne;
            Console.BackgroundColor = colorTwo;
            Console.Write(str);
        }

        static void ConsoleOptions()
        {
            Console.Title = "CHICKEN EGGS!!!";

            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 80;
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void EnterName()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, Console.WindowHeight - 12);
            Console.WriteLine(new string('_', 80));
            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight - 10);
            Console.WriteLine("LEGEND:\n");
            Console.WriteLine("       ||  Green Shit: +20 Speed   ||   Purple Shit: -20 Speed  ||");
            Console.WriteLine("\n");
            Console.WriteLine("       ||  White Egg: +20 Points   ||   Dark Red Bomb: -1 Live  ||");
            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.WriteLine(new string('_', 80));
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ENTER YOUR NAME (letters and digits only):");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 5);


            // Exception handling
            bool isValid = true;
            do
            {
                isValid = true;
                try
                {
                    name = Console.ReadLine();
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!(char.IsDigit(name[i]) || char.IsLetter(name[i]) || name[i] == ' '))
                        {
                            isValid = false;
                            throw new Exception();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 17, Console.WindowHeight / 2 - 4);
                    Console.WriteLine("YOUR NAME IS TOO STRANGE DUDE!");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 17, Console.WindowHeight / 2 - 3);
                    Console.WriteLine("TRY AGAIN :)");
                    ClearCurrentConsoleLine();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 17, Console.WindowHeight / 2 - 5);
                }
            } while (isValid == false);
            Console.Clear();

        }

        static void Clear(int x, int y, int width, int height)
        {
            int curTop = Console.CursorTop;
            int curLeft = Console.CursorLeft;
            Console.BackgroundColor = ConsoleColor.Black;

            for (; height > 0; )
            {
                Console.SetCursorPosition(x, y + --height);
                Console.Write(new string(' ', width));
            }

            Console.SetCursorPosition(curLeft, curTop);
        }

        static void InitiallyAddingThings()
        {
            int chance = rnd.Next(1, 10);

            if (chance > 6)
            {
                for (int i = 0; i < rnd.Next(0, 2); i++)
                {
                    IForm newForm = GenerateFigure();
                    if (newForm.Color == ConsoleColor.White)
                    {
                        if (CheckFreePositionForEgg(newForm))
                        {
                            falliingThings.Add(newForm);
                            FillFreePositions(newForm);
                        }
                    }
                    else if (newForm.Color == ConsoleColor.Green || newForm.Color == ConsoleColor.Magenta)
                    {
                        if (CheckFreePositionForShit(newForm))
                        {
                            falliingThings.Add(newForm);
                            FillFreePositions(newForm);
                        }
                    }
                    else if (newForm.Color == ConsoleColor.DarkRed)
                    {
                        if (CheckFreePositionForBomb(newForm))
                        {
                            falliingThings.Add(newForm);
                            FillFreePositions(newForm);

                        }
                    }
                }
            }
        }

        private static void FillFreePositions(IForm form)
        {
            for (int row = form.Row; row < form.Row + form.Vision.GetLength(0); row++)
            {
                for (int col = form.Col; col < form.Col + form.Vision.GetLength(1); col++)
                {
                    freePositions[row, col] = true;
                }
            }
        }

        private static bool CheckFreePositionForBomb(IForm form)
        {
            if (form.Col + 4 >= playWidth)
            {
                return false;
            }

            for (int row = form.Row; row <= form.Row + form.Vision.GetLength(0); row++)
            {
                for (int col = form.Col; col < form.Col + form.Vision.GetLength(1); col++)
                {
                    if (freePositions[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool CheckFreePositionForShit(IForm form)
        {
            if (form.Col + 2 >= playWidth)
            {
                return false;
            }

            for (int row = form.Row; row <= form.Row + form.Vision.GetLength(0); row++)
            {
                for (int col = form.Col; col < form.Col + form.Vision.GetLength(1); col++)
                {
                    if (freePositions[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool CheckFreePositionForEgg(IForm form)
        {
            if (form.Col + 4 >= playWidth)
            {
                return false;
            }

            for (int row = form.Row; row <= form.Row + form.Vision.GetLength(0); row++)
            {
                for (int col = form.Col; col < form.Col + form.Vision.GetLength(1); col++)
                {
                    if (freePositions[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static Form GenerateFigure()
        {
            int currentForm = rnd.Next(0, forms);
            int row = rnd.Next(7, 7);
            int col = rnd.Next(3, playWidth);
            //Create Egg
            if (currentForm == 0)
            {
                Egg egg = new Egg(row, col);
                return egg;
            }
            //Create Purple Shit
            else if (currentForm == 1)
            {
                Shit purpleShit = new Shit(row, col, ConsoleColor.Magenta);
                return purpleShit;
            }
            //Create Bomb
            else if (currentForm == 2)
            {
                Bomb bomb = new Bomb(row, col);
                return bomb;
            }
            //if (currentForm == 3) Create Shit
            else
            {
                Shit shit = new Shit(row, col, ConsoleColor.Green);
                return shit;
            }
        }

        static void Entrance()
        {
            StreamReader reader = new StreamReader(@"..\..\scores.txt");

            //Exception One
            if (@"..\..\scores.txt" == null)
            {
                throw new System.ArgumentNullException();
            }
            List<uint> points = new List<uint>();
            List<string> names = new List<string>();
            List<string> dates = new List<string>();
            using (reader)
            {
                for (int i = 0; i < 5; i++)
                {
                    string input = reader.ReadLine();
                    if (input == null)
                    {
                        break;
                    }
                    string[] separated = input.Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);
                    points.Add(uint.Parse(separated[0]));
                    names.Add(separated[1]);
                    dates.Add((separated[2]));
                }
            }
            if (points.Count == 0 || (points.Count < 5 && score <= points.Last()))
            {
                points.Add(score);
                DateTime currentDate = DateTime.Now;
                string dateNow = currentDate.ToString("dd/MM/yyyy");
                names.Add(name);
                dates.Add(dateNow);
            }
            for (int j = 0; j < points.Count; j++)
            {
                if (score > points[j])
                {
                    points.Insert(j, score);
                    names.Insert(j, name);
                    DateTime currentDate = DateTime.Now;
                    string dateNow = currentDate.ToString("dd/MM/yyyy");
                    dates.Insert(j, dateNow);
                    break;
                }
            }
            if (points.Count == 6)
            {
                points.RemoveAt(5);
                names.RemoveAt(5);
                dates.RemoveAt(5);
            }
            StreamWriter writer = new StreamWriter(@"..\..\scores.txt");
            using (writer)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(Console.WindowWidth - 24, Console.WindowHeight / 2 - 5);
                Console.WriteLine("High scores:");
                string namesFirstCh = string.Empty;
                for (int m = 0; m < points.Count; m++)
                {

                    if (names[m].Length > 4)
                    {
                        namesFirstCh = names[m].Substring(0, 5);
                    }
                    else
                    {
                        namesFirstCh = names[m];
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(Console.WindowWidth - 24, Console.WindowHeight / 2 - 3 + m);
                    Console.WriteLine("{0, 3} {1, -6} {2}", points[m], names[m], dates[m]);
                    writer.WriteLine("{0, 3} {1, -6} {2}", points[m], names[m], dates[m]);

                }
            }


            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER!");
            Console.ResetColor();
            lives = 3;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 + 1);
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your points: {0,5}", score);
            Console.ResetColor();

            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PLEASE, PRESS [ENTER]");

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ReadKey();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth - 50, Console.WindowHeight / 2 - 3);
            Console.Write("Do you want to play again?\n\n");
            Console.SetCursorPosition(Console.WindowWidth - 50, Console.WindowHeight / 2 - 2);
            Console.Write("Press [ENTER] to start new game");
            Console.SetCursorPosition(Console.WindowWidth - 50, Console.WindowHeight / 2 - 1);
            Console.Write("or press any other key to EXIT");

            Console.ResetColor();
            Console.SetCursorPosition(0, Console.WindowHeight - 1);

            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                Main();

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GOOD BYE TRAINER !");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 + 5);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("TEAM RED DRAGON");

                Console.ResetColor();
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Environment.Exit(1);
            }

        }

        struct PlayerPosition
        {
            public int x;
            public int y;

            public PlayerPosition(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static void Print(char[,] matrix, int row, int col, ConsoleColor color)
        {
            int startCol = col;
            int printRow = row + matrix.GetLength(0);

            Console.ForegroundColor = color;

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                printRow--;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i <= 13)
                    {
                        if (col < playWidth && printRow < 13)
                        {
                            freePositions[row, col] = true;
                        }
                    }

                    if (printRow < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(col, printRow);
                        Console.Write(matrix[i, j]);

                    }
                    col++;
                }
                col = startCol;
            }

            Console.ResetColor();
        }

        public static void Beep(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.Beep();
            }
        }
    }
}
