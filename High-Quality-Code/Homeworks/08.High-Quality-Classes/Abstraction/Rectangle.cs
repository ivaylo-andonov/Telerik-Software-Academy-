namespace Abstraction
{
    using System;

    internal class Rectangle : Figure
    {
        private double width;
        private double height;

        internal Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        internal double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.Validator.CheckForNegativeValue(value, "Width must be a positive double value");
                this.width = value;
            }
        }

        internal double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validator.Validator.CheckForNegativeValue(value, "Height must be a positive double value");
                this.height = value;
            }
        }

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        internal override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}