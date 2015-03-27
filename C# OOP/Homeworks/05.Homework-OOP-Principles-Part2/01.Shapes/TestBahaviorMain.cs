namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    class TestBahaviorMain
    {
        static void Main()
        {
            Shape[] shapesArray = {
                                      new Triangle(5, 6),
                                      new Rectangle(7, 10),
                                      new Square(4, 4)
                                  };

            Console.WriteLine("------SHAPES------");
            Console.WriteLine();

            foreach (var shape in shapesArray)
            {
                Console.Write("{0} area: ", shape.GetType().Name);
                shape.CalculateSurface();
            }
            Console.WriteLine();
        }
    }
}
