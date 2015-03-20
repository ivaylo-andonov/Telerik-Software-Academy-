namespace _01.Task3D_1_4_
{
    using System;

    public struct Point3D
    {
        //Static fields
        public static readonly Point3D startPoint;

        // Fields               Problem 1
        private double x;
        private double y;
        private double z;
        

        //Static constructors     Problem 2
        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }

        // Constructors with params
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Properties                        Problem 1
        public static Point3D StartPoint
        {
            get { return startPoint; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // Override method ToSTring()
        public override string ToString()
        {
            return string.Format("[X: {0} ; Y: {1} ; Z: {2} ]", this.X, this.Y, this.Z);
        }
    }
}
