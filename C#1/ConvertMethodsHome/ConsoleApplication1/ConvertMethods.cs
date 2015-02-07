using System;

class Program
{
    static void Main(string[] args)
    {
        int decimalOne = 307;   // Convert decimal to binary
        string binaryOne = Convert.ToString(decimalOne,2);
        Console.WriteLine(binaryOne);

        int decimalTwo = 307; // Convert decimal to binary with PadLeft
        string binaryTwo = Convert.ToString(decimalTwo, 2).PadLeft(16, '0');
        Console.WriteLine(binaryTwo);

        string binaryThree = "1010101010101011";   // Convert binary to decimal
        int decimalThree = Convert.ToInt32(binaryThree, 2);
        Console.WriteLine(decimalThree);

        int decimalNum = 123; //Convert decimal to hex
        string hexNum = Convert.ToString(decimalNum, 16);
        Console.WriteLine(hexNum);

        string hexNumTwo = "4F5"; // Convert hex to decimal
        int decimalNumTwo = Convert.ToInt32(hexNumTwo,16);
        Console.WriteLine(decimalNumTwo);

        int? ivo = null; // Prisvoqvane na nuleva za int ,double;
        Console.WriteLine(ivo);



    }
}