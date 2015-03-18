namespace _01.DefineClass
{
    using System;

    public class Display
    {
        // Const fields 
        private const double DIAGONAL_SIZE = 11;
        private const long NUMBER_COLORS_DISPLAY = 16000000;

        //Fields
        private double widthOfGSM;
        private double heigthOfGSM;
        private double diagonalDisplaySIze;
        private long colorsOfDisplay;


        // Constructors
        public Display()     // Empty constructor inherite default const values
            :this(DIAGONAL_SIZE,NUMBER_COLORS_DISPLAY)
        {
        }

        public Display(double diagonalDisplaySIze)
        {
            this.DiagonalDisplaySIze = diagonalDisplaySIze;
        }

        public Display(double diagonalDisplaySIze, long numbersOfColors)
            : this(diagonalDisplaySIze)
        {
            this.ColorsOfDisplay = numbersOfColors;
        }

        public Display(double widthX, double heigthY,long numbersOfColors)
        {
            this.WidthSize = widthX;
            this.HeigthSize = heigthY;
            this.ColorsOfDisplay = numbersOfColors;
            this.DiagonalDisplaySIze = CalculateDiagonalSize(widthX, heigthY);  // Use method to show easier the size of display
        }
       
  
        // Properties
        public double WidthSize
        {
            get
            {
                return this.widthOfGSM;
            }
            private set
            {
                if (value <= 2 || value > 20)
                {
                    throw new ArgumentException("The width of your phone`s display should be bigger than 2cm and smaller than 15 cm");
                }
                else this.widthOfGSM = value;
            }
        }

        public double HeigthSize
        {
            get
            {
                return this.heigthOfGSM;
            }
            private set
            {
                if (value <= 2 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("The heigth of your phone`s display should be bigger than 2cm and smaller than 15 cm");
                }
                else this.heigthOfGSM = value;
            }
        }
        public double DiagonalDisplaySIze
        {
            get
            {
                return this.diagonalDisplaySIze;
            }
            private set
            {
                if (value <= 2 )
                {
                    throw new ArgumentOutOfRangeException("Diagonal size of your display should be bigger than 2cm");
                }
                else this.diagonalDisplaySIze = value;
            }

        }

        public long ColorsOfDisplay
        {
            get
            {
                return this.colorsOfDisplay;
            }
            private set
            {
                this.colorsOfDisplay = value;
                if (colorsOfDisplay > 1000000)
                {
                    string numberAsString = string.Empty;
                    numberAsString = colorsOfDisplay.ToString().Trim('0');
                    colorsOfDisplay = int.Parse(numberAsString);
                }
            }
        }

        // Override method ToString()
        public override string ToString()   // Problem 5
        {
            return String.Format("Display Width/Heigth: {0:F1} x {1:F1}\n" + "Diagonal size: {2:F2} cm \n" + "Number of colors: {3}M \n",
                this.WidthSize,this.HeigthSize,this.DiagonalDisplaySIze, this.ColorsOfDisplay);
        }
        
        // Method finds the diagonal size of gsm by WidthX and HeigthY od display
        public double CalculateDiagonalSize(double sizeX, double sizeY)
        {
            double sizeOfGsm = 0;
            sizeOfGsm = Math.Sqrt(sizeX * sizeX + sizeY*sizeY);
            return sizeOfGsm;
        }
    }    
}
