namespace _01.Task3D_1_4_
{
    using System;
    using System.Collections.Generic;

    public class Path   // Problem 4
    {
        // Field ( to hold sequence of points)
        List<Point3D> pointSequence;

        //Empty constructor for class Path
        public Path()
        {
            this.pointSequence = new List<Point3D>();
        }

        // Property Count of the sequence
        public int Count
        {
            get { return this.pointSequence.Count; }
        }

        // Indexator of the sequence
        public Point3D this[int index]
        {
            get
            {
                if (index < 0 || index > pointSequence.Count)
                {
                    throw new ArgumentException("Invalid input");
                }
                return this.pointSequence[index];
            }
            set
            {
                if (index < 0 || index > pointSequence.Count)
                {
                    throw new ArgumentException("Invalid input");
                }
                this.pointSequence[index] = value;
            }
        }

        // Method to Add point into List<Point3D>
        public void AddPoint(Point3D point)
        {
            this.pointSequence.Add(point);
        }

        // Method to Remove point into List<Point3D>
        public void RemovePoint(Point3D point)
        {
            this.pointSequence.Remove(point);
        }

        // Ovveride ToString()
        public override string ToString()
        {
            return String.Join(Environment.NewLine, this.pointSequence);
        }
    }
}
