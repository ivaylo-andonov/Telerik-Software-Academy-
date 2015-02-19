//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class Program
{
    static void Main()
    {

        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            double root = Math.Sqrt(number);
            Console.WriteLine("The square root is {0:F2}", root);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input!The number is too big or too small! ");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid input! Can not calculate square root of negaive number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid input! End of input is wrong!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Data entered is not a valid number!");
        }
        finally
        {
            Console.WriteLine("\nGood bye");
        }
    }
}

