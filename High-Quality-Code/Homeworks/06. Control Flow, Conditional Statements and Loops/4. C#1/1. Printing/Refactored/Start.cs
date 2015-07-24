namespace Printing
{
    using System;

    public class Start
    {
        public static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            double realmPrice = double.Parse(Console.ReadLine());

            double totalSheets = studentsCount * sheetsPerStudent;
            double moneySaved = (totalSheets / 500) * realmPrice;

            Console.WriteLine("{0:F2}", moneySaved);
        }
    }
}
