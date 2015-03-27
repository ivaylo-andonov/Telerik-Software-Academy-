namespace _01.Shapes
{
    using System;

    public class Triangle : Shape
    {
        //Constructors
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        //Methods
        public override void CalculateSurface()
        {
            double surface = 0;
            surface = ((this.Width * this.Height) / 2);
            Console.WriteLine(surface);
        }
    }
}
