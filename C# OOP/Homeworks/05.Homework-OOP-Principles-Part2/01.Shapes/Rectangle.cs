namespace _01.Shapes
{
    using System;

    public class Rectangle : Shape
    {
         //Constructors
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        //Methods
        public override void CalculateSurface()
        {
            double surface = 0;
            surface = (this.Width * this.Height);
            Console.WriteLine(surface);
        }
    }
}
