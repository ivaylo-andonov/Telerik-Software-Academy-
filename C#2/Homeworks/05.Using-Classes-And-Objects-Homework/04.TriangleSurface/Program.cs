﻿/* Write methods that calculate the surface of a triangle by given: 
 * - Side and an altitude to it; 
 * - Three sides; 
 * - Two sides and an angle between them. 
 * Use System.Math. */

using System;

class Triangle
{
    public double area;

    public double Area
    { get { return area; } }

    public double SurfaceBySideAndAltitude(double side, double altitude)
    {
        area = 0.5d * side * altitude;
        return area;
    }

    public double SurfaceByThreeSides(double sideA, double sideB, double sideC)
    {
        double s = (sideA + sideB + sideC) / 2.0d;
        area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        return area;
    }
    public double SurfaceByTwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        area = 0.5d * sideA * sideB * Math.Sin(angle * Math.PI / 180);
        return area;
    }
}

class TriangleSurface
{
    static void Main()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("This program calculate surface of a trinagle by:\n");
            Console.WriteLine("A. Side and altitude to it");
            Console.WriteLine("B. Three sides");
            Console.WriteLine("C. Two sides and an angle (in degrees) between them");
            Console.WriteLine("D. Exit");
            string choice;
            do
            {
                Console.Write("Enter A, B, C or D and press <Enter>: ");
                choice = Console.ReadLine().ToUpper();
            } while (choice != "A" && choice != "B" && choice != "C" && choice != "D");

            Triangle triangle = new Triangle();
            double sideA;
            double sideB;
            double sideC;
            double altitude;
            double angle;

            switch (choice)
            {
                case "A":
                    Console.Write("Enter lenght of side: ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter lenght of altitude: ");
                    altitude = double.Parse(Console.ReadLine());
                    triangle.SurfaceBySideAndAltitude(sideA, altitude);
                    break;
                case "B":
                    Console.Write("Enter lenght of side A: ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter lenght of side B: ");
                    sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter lenght of side C: ");
                    sideC = double.Parse(Console.ReadLine());
                    triangle.SurfaceByThreeSides(sideA, sideB, sideC);
                    break;
                case "C":
                    Console.Write("Enter lenght of side A: ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter lenght of side B: ");
                    sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter angle (in degrees): ");
                    angle = double.Parse(Console.ReadLine());
                    triangle.SurfaceByTwoSidesAndAngle(sideA, sideB, angle);
                    break;
                case "D":
                    return;
            }
            Console.WriteLine("The area of triangle is {0:F1}", triangle.Area);
            Console.ReadLine();
        } while (true);
    }
}