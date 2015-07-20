/* Task 1. Class Size
 * StyleCop settings: disabled: Documentation Rules
*/
namespace _01.Task_Size
{
    using System;

    public class Shape
    {
        private double width, height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public static Shape GetRotatedFigure(Shape shape, double angleOfTheShapeToBeRotaed)
        {
            double newRotatedWidth = (Math.Abs(Math.Cos(angleOfTheShapeToBeRotaed)) * shape.width) +
                    (Math.Abs(Math.Sin(angleOfTheShapeToBeRotaed)) * shape.height);

            double newRotaredHeigth = (Math.Abs(Math.Sin(angleOfTheShapeToBeRotaed)) * shape.width) +
                    (Math.Abs(Math.Cos(angleOfTheShapeToBeRotaed)) * shape.height);

            Shape rotatedFigure = new Shape(newRotatedWidth, newRotaredHeigth);

            return rotatedFigure;
        }

        public static void Main()
        {

        }
    }
}
