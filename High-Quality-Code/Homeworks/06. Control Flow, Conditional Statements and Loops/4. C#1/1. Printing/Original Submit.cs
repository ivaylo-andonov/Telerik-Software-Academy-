using System;

class Printing
{
    static void Main()
    {
        //Console.Write("Enter students number: ");
        int studentCount = int.Parse(Console.ReadLine());
        //Console.Write("Enter sheets per student: ");
        int sheetsStudent = int.Parse(Console.ReadLine());
        //Console.Write("Enter realm price: ");
        double realmPrice = double.Parse(Console.ReadLine());

        int totalSheets = studentCount * sheetsStudent;
        double moneySaved = ((double)totalSheets / 500) * realmPrice;

        Console.WriteLine("{0:F2}", moneySaved);
    }
}