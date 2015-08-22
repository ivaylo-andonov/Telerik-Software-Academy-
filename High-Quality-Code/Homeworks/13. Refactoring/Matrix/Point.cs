// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Point.cs" company="">
//   
// </copyright>
// <summary>
//   The point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Matrix
{
    /// <summary>
    ///     The point.
    /// </summary>
    internal class Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        ///     Gets the x.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///     Gets the y.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        ///     The +.
        /// </summary>
        /// <param name="p1">
        ///     The p 1.
        /// </param>
        /// <param name="p2">
        ///     The p 2.
        /// </param>
        /// <returns>
        /// </returns>
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}