using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HtmlTable : HtmlElement, ITable
    {
        private const string TableName = "table";
        private const string TableRowOpenTag = "<tr>";
        private const string TableRowCloseTag = "</tr>";
        private const string TableCellOpenTag = "<td>";
        private const string TableCellCloseTag = "</td>";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public HtmlTable(int rows, int cols)
            : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get { return this.rows; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "HTML table rows count must be positive!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "HTML table columns count must be positive!");
                }

                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateIndecies(row, col);
                return this.cells[row, col];
            }

            set
            {
                this.ValidateIndecies(row, col);
                if (value == null)
                {
                    throw new ArgumentNullException("value", "HTML element in table cell cannot be null!");
                }

                this.cells[row, col] = value;
            }
        }

        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have child elements!");
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("Cannot get text content of HTML table because it does not have such!");
            }

            set
            {
                throw new InvalidOperationException("Cannot set text content of HTML table because it does not have such!");
            }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("HTML tables do not have child elements so such cannot be added!");
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append(TableRowOpenTag);

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TableCellOpenTag);

                    output.Append(this.cells[row, col].ToString());

                    output.Append(TableCellCloseTag);
                }

                output.Append(TableRowCloseTag);
            }

            output.AppendFormat("</{0}>", this.Name);
        }

        private void ValidateIndecies(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("Provided row is out of the boundaries of the HTML table!");
            }

            if (col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Provided column is out of the boundaries of the HTML table!");
            }
        }
    }
}
