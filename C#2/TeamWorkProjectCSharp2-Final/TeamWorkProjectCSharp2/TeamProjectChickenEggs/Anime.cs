using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamProjectKoko
{
    class Anime
    {
        
        public static void PrintAnimation()
        {
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 80;

            Console.CursorVisible = false;

            var chickenEggs = new[]
            {

         
         @"   .d8888b.  888      d8b          888                          ",
         @"  d88P  Y88b 888      Y8P          888                          ",
         @"  888    888 888                   888                          ",
         @"  888        88888b.  888  .d8888b 888  888  .d88b.  88888b.    ",
         @"  888        888  88b 888 d88P     888 .88P d8P  Y8b 888  88b   ",
         @"  888    888 888  888 888 888      888888K  88888888 888  888   ",
         @"  Y88b  d88P 888  888 888 Y88b.    888  88b Y8b.     888  888   ",
         @"    Y8888P   888  888 888   Y8888P 888  888   Y8888  888  888   ",
         @"                                                                ",
         @"                                                                ",
         @"                                                                ",
         @"         8888888888                                             ",
         @"         888                                                    ",
         @"         888                                                    ",
         @"         8888888     .d88b.   .d88b.  .d8888b                   ",
         @"         888        d88P 88b d88P 88b 88K                       ",
         @"         888        888  888 888  888  Y8888b.                  ",
         @"         888        Y88b 888 Y88b 888      X88                  ",
         @"         8888888888   Y88888   Y88888  88888P                   ",
         @"                         888      888                           ",
         @"                    Y8b d88P Y8b d88P                           ",
         @"                      Y88P     Y88P                             "
            };

            var redDragon = new[]
            {
                                                                                                                        
 @"                       ***** ***                 **                               ",
 @"                    ******  * **                  **                              ",
 @"                   **   *  *  **                  **                              ",
 @"                  *    *  *   **                  **                              ",
 @"                      *  *    *                   **                              ",
 @"                     ** **   *       ***      *** **                              ",
 @"                     ** **  *       * ***    *********                            ",
 @"                     ** ****       *   ***  **   ****                             ",
 @"                     ** **  ***   **    *** **    **                              ",
 @"                     ** **    **  ********  **    **                              ",
 @"                     *  **    **  *******   **    **                              ",
 @"                        *     **  **        **    **                              ",
 @"                    ****      *** ****    * **    **                              ",
 @"                   *  ****    **   *******   *****                                ",
 @"                  *    **     *     *****     ***                                 ",
 @"                  *                                                               ",
 @"                   **                                                                             ",
 @"          ***** **                                                                ",
 @"       ******  ***                                                                ",
 @"     **    *  * ***                                                               ",
 @"    *     *  *   ***                                                              ",
 @"         *  *     *** ***  ****                        ****                       ",
 @"        ** **      **  **** **** * ****     ****      * ***  * ***  ****          ",
 @"        ** **      **   **   **** * ***  * *  ***  * *   ****   **** **** *       ",
 @"        ** **      **   **       *   **** *    **** **    **     **   ****        ",
 @"        ** **      **   **      **    ** **     **  **    **     **    **         ",
 @"        ** **      **   **      **    ** **     **  **    **     **    **         ",
 @"        *  **      **   **      **    ** **     **  **    **     **    **         ",
 @"           *       *    **      **    ** **     **  **    **     **    **         ",
 @"      *****       *     ***     **    ** **     **   ******      **    **         ",
 @"     *   *********       ***     ***** ** ********    ****       ***   ***        ",
 @"    *       ****                  ***   **  *** ***               ***   ***       ",
 @"    *                                            ***                              ",
 @"     **                                    ****   ***                             ",
 @"                                         *******  **                              ",
 @"                                        *     ****                                ",              
                                                                                              
                                                                                                  
            };



            var maxLength = redDragon.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 + 10 - maxLength / 2;


            //Print dragon text

            for (int y = -redDragon.Length * 2; y < Console.WindowHeight + chickenEggs.Length; y++)
            {

                Console.ForegroundColor = ConsoleColor.Red;

                ConsoleDrawRedDragonLogo(redDragon, y - 3, y);
                Thread.Sleep(30);
                Console.ResetColor();
            }


            // Print ChickenEggs logo
            Console.Clear();
            for (int y = -chickenEggs.Length; y < Console.WindowHeight + chickenEggs.Length; y++)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;

                ConsoleDrawChickenEggsLogo(chickenEggs, x + 8, y);
                Thread.Sleep(50);

                Console.ResetColor();
            }

        }
        public static void ConsoleDrawRedDragonLogo(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight / 15) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex < 40 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();


            foreach (var line in linesToPrint)
            {

                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);

            }



        }
        public static void ConsoleDrawChickenEggsLogo(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth - 10) return;
            if (y > Console.WindowHeight / 3) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();


            foreach (var line in linesToPrint)
            {

                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);

            }
        }
    }
}
