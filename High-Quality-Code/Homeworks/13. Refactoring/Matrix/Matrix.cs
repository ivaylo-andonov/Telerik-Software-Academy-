namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Matrix
    {
        private readonly List<Point> directions = new List<Point>
		  {
			  new Point(1, 1), // down right
			  new Point(1, 0), // down
			  new Point(1, -1), // down left
			  new Point(0, -1), // left
			  new Point(-1, -1), // up left
			  new Point(-1, 0), // up
			  new Point(-1, 1), // up right
			  new Point(0, 1) // right
		  };

        private readonly int[,] matrix;

        private int currentDirectionIndex;

        /// Initializes a new instance of the Matrix class.
        public Matrix(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Input value should be more than 1");
            }

            this.matrix = new int[n, n];
            this.currentDirectionIndex = 0;
            this.FillMatrixValues();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < this.matrix.GetLength(0); j++)
                {
                    sb.Append(string.Format("{0,3}", this.matrix[i, j]));
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        ///  The fill matrix values.		
        private void FillMatrixValues()
        {
            var currentPosition = new Point(0, 0);
            var currentWriteValue = 1;

            do
            {
                this.matrix[currentPosition.X, currentPosition.Y] = currentWriteValue;
                currentPosition = this.Move(currentPosition) ?? this.GetFirstFreeCell();

                currentWriteValue++;
            }
            while (currentPosition != null);
        }

        private Point Move(Point point)
        {
            for (var i = this.currentDirectionIndex; i < this.directions.Count + this.currentDirectionIndex; i++)
            {
                var newPoint = point + this.directions[i % this.directions.Count];
                if (this.IsPointInMatrixRange(newPoint) && (this.matrix[newPoint.X, newPoint.Y] == 0))
                {
                    this.currentDirectionIndex = i % this.directions.Count;
                    return newPoint;
                }
            }

            return null;
        }

        /// Is point in matrix range.
        private bool IsPointInMatrixRange(Point point)
        {
            return point.X >= 0 && point.X < this.matrix.GetLength(0) && point.Y >= 0
                   && point.Y < this.matrix.GetLength(0);
        }

        ///  The get first free cell.
        private Point GetFirstFreeCell()
        {
            var p = new Point(0, 0);

            for (var i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < this.matrix.GetLength(0); j++)
                {
                    if (this.matrix[i, j] == 0)
                    {
                        p.X = i;
                        p.Y = j;
                        this.currentDirectionIndex = 0;
                        return p;
                    }
                }
            }

            return null;
        }
    }
}