namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        // Fields
        private double width;
        private double height;

        //Constructors
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        //Properties
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width cannot be 0 or less!");
                }

                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height cannot be 0 or less!");
                }

                this.height = value;
            }
        }

        // Abstract method ,should be implement in child classes
        public abstract void CalculateSurface();
    }
}
