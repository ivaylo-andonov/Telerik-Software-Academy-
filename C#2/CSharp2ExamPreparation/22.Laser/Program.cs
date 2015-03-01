using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int cubeWIdth = int.Parse(line[0]);
            int cubeHeight = int.Parse(line[1]);
            int cubeDepth = int.Parse(line[2]);

            bool[, ,] cube = new bool[cubeWIdth, cubeHeight, cubeDepth];

            for (int w = 0; w < cubeWIdth; w++)
            {
                cube[w, 0, 0] = true;
                cube[w, cubeHeight - 1, 0] = true;
                cube[w, 0, cubeDepth - 1] = true ;
                cube[w, cubeHeight - 1, cubeDepth - 1] = true;
            }

            for (int d = 0; d < cubeDepth; d++)
            {
                cube[0, 0, d] = true;
                cube[cubeWIdth -1, 0, d] = true;
                cube[0, cubeHeight - 1, d] = true;
                cube[cubeWIdth  -1 , cubeHeight - 1, d] = true;
            }

            for (int h = 0; h < cubeHeight; h++)
            {
                cube[0,h,0] = true;
                cube[cubeWIdth - 1, h, 0] = true;
                cube[0, h, cubeDepth - 1] = true;
                cube[cubeWIdth - 1, h, cubeDepth - 1] = true;
            }

            PrintFloor(cube, 6);
        }

        private static void PrintFloor(bool[, ,] cube, int h)
        {
            
        }
    }

