namespace CohesionAndCoupling
{
    using System;

    using Abstraction.Validator;

    internal class Shape
    {
        private double width;
        private double height;
        private double depth;

        internal Shape(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        internal double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.CheckForNegativeValue(value, "Width must be a positive double value");
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
                Validator.CheckForNegativeValue(value, "Height must be a positive double value");
                this.height = value;
            }
        }

        internal double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                Validator.CheckForNegativeValue(value, "Depth must be a positive double value");
                this.depth = value;
            }
        }

        internal double CalcVolume()
        {
            double volume = this.Depth * this.Height * this.Depth;
            return volume;
        }

        internal double CalcDiagonalXYZ()
        {
            double distance = DistanceUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        internal double CalcDiagonalXY()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        internal double CalcDiagonalXZ()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        internal double CalcDiagonalYZ()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
