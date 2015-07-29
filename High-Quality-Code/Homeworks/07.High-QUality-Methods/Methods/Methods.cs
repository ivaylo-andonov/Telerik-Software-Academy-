namespace Methods
{
    using System;
    using System.Text;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The Sides must be possitive numbers");
            }

            double surface = (a + b + c) / 2;
            double area = Math.Sqrt(surface * (surface - a) * (surface - b) * (surface - c));
            return area;
        }

        public static string DigitAsWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";

                case 1:
                    return "one";

                case 2:
                    return "two";

                case 3:
                    return "three";

                case 4:
                    return "four";

                case 5:
                    return "five";

                case 6:
                    return "six";

                case 7:
                    return "seven";

                case 8:
                    return "eight";

                case 9:
                    return "nine";

                default:
                    throw new ArgumentException("Invalid digit");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Params cannot be null or empty");
            }

            int maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        public static void PrintAsNumber(double number, string format)
        {
            switch (format)
            {
                case "f":
                    Console.WriteLine(number.ToString("F2"));
                    break;
                case "%":
                    Console.WriteLine(number.ToString("P"));
                    break;
                case "r":
                    Console.WriteLine(number.ToString("R8"));
                    break;
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = y1.Equals(y2);
            isVertical = x1.Equals(x2);

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}
