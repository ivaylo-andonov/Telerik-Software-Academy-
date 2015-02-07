using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FallingRocks
{
    class FallingRocks
    {
        class Item
        {
            public int X, Y;
            public string Type, Empty;
            public ConsoleColor Color;
            public Item(int x, int y, ConsoleColor color, string type)
            {
                this.X = x;
                this.Y = y;
                this.Color = color;
                this.Type = type;
                for (int i = 0; i < this.Type.Length; i++)
                {
                    this.Empty += " ";
                }
            }
            public void Display()
            {
                Console.SetCursorPosition(this.X, this.Y);
                Console.ForegroundColor = this.Color;
                Console.Write(this.Type);
            }
            public void Clear()
            {
                Console.SetCursorPosition(this.X, this.Y);
                Console.Write(this.Empty);
            }
        }
        class Dwarf : Item
        {
            public Dwarf()
                : base(Console.WindowWidth / 2,
                Console.WindowHeight - 1,
                ConsoleColor.DarkYellow,
                "(0)")
            { }
            public void Move(ConsoleKeyInfo pressedKey)
            {
                switch (pressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (this.X > 0)
                        {
                            this.Clear();
                            this.X--;
                            this.Display();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (this.X < Console.WindowWidth - 2 - 2)
                        {
                            this.Clear();
                            this.X++;
                            this.Display();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static void Main()
        {
            Random rnd = new Random();
            string[] rockTypes = { "!", "@", "#", "$", "%", "^", "&", "*", ".", ";" };
            List<Item> rocks = new List<Item>();
            long score = 0;
            double SleepTime = 200;
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.WriteLine("Falling rocks game!");
            Console.WriteLine("Use the arrow keys to move the dwarf (0) at the bottom.");
            Console.WriteLine("Try to avoid being hit!");
            Console.WriteLine("Press one of the arrows to start...");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.LeftArrow ||
            pressedKey.Key == ConsoleKey.RightArrow)
            {
                Dwarf dwarf = new Dwarf();
                dwarf.Display();
                while (true)
                {
                    for (int i = rnd.Next(0, 3); i < 4; i++) //randomly generate 1-4 new rocks
                    {
                        Item rock = new Item(rnd.Next(0, Console.WindowWidth - 1),
                        0,
                        (ConsoleColor)rnd.Next((int)ConsoleColor.Blue, (int)ConsoleColor.White),
                        rockTypes[rnd.Next(rockTypes.Length)]);
                        rock.Display(); //displaying the rocks
                        rocks.Add(rock); //adding the rocks to a list
                    }
                    foreach (Item i in rocks) //generating falling of rocks
                    {
                        i.Clear();
                        i.Y++;
                        if (i.Y < (Console.WindowHeight)) i.Display(); //showing the fallen rock only in the field
                        else score++; //adding score for each fallen rock
                        if ((i.X >= dwarf.X) &&
                        (i.X <= dwarf.X + 2) &&
                        (i.Y >= dwarf.Y) &&
                        (i.Y <= dwarf.Y + 2))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Game over!!!");
                            Console.WriteLine("Your score is {0} points!", score);
                            return;
                        }
                    }
                    rocks.RemoveAll(i => i.Y >= (Console.WindowHeight));
                    if (Console.KeyAvailable)
                    {
                        dwarf.Move(Console.ReadKey());
                    }
                    Thread.Sleep((int)SleepTime);
                    SleepTime -= 0.05;
                }
            }
        }
    }
}