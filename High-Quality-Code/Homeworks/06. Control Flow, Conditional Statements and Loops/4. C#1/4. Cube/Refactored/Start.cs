namespace Cube
{
    using System;

    public class Start
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char cubeLinePen = ':';
            char cubeTopPen = '/';
            char cubeSidePen = 'X';
            char cubeFrontPen = ' ';
            char background = ' ';

            Console.WriteLine(new string(background, n - 1) + new string(cubeLinePen, n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string(background, n - 2 - i) + cubeLinePen + new string(cubeTopPen, n - 2) + cubeLinePen + new string(cubeSidePen, i) + cubeLinePen);
            }

            Console.WriteLine(new string(cubeLinePen, n) + new string(cubeSidePen, n - 2) + cubeLinePen);

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(cubeLinePen + new string(cubeFrontPen, n - 2) + cubeLinePen);
                Console.WriteLine(new string(cubeSidePen, n - 3 - i) + cubeLinePen);
            }

            Console.WriteLine(new string(cubeLinePen, n));
        }
    }
}
