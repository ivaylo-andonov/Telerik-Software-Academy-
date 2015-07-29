namespace Abstraction
{
    using System;

    public class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);

            Console.WriteLine(circle.ToString());

            Rectangle rect = new Rectangle(2, 3);

            Console.WriteLine(rect.ToString());
        }
    }
}